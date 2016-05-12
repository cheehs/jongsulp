//-------------------------------------------------------------------------
//
//  This is part of the Microsoft Tablet PC Platform SDK
//  Copyright (C) 2002 Microsoft Corporation
//  All rights reserved.
//
//  This source code is only intended as a supplement to the
//  Microsoft Tablet PC Platform SDK Reference and related electronic 
//  documentation provided with the Software Development Kit.
//  See these sources for more detailed information. 
//
//  File: InkRecognition.cs
//  Simple Ink Recognition Sample Application
//
//  This program demonstrates how one can build a basic handwriting 
//  recognition application using Microsoft Tablet PC Automation API. 
//  It first creates an InkCollector object to enable inking
//  in the window. Upon receiving the "Recognize!" command, fired
//  from the application's button, ToString() is invoked on the 
//  collected ink strokes to retrieve the best match using the
//  default recognizer.  The results are presented in a message box.
//
//  The features used are: InkCollector, Ink, Strokes, 
//  RecognizerContext, and RecognizerResult
//
//--------------------------------------------------------------------------


using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// The Ink namespace, which contains the Tablet PC Platform API
using Microsoft.Ink;

namespace InkRecognition
{
    /// <summary>
    /// The InkRecognition Sample Application form class
    /// </summary>
	public class InkRecognition : System.Windows.Forms.Form
	{
        string a;
        FileStream fs = File.Create("output.txt");
        // Declare the Ink Collector object
        private InkCollector myInkCollector;

        // myRecognizers is used to retrieve the number of installed recognizers
        Recognizers myRecognizers;

        #region Standard Template Code
        private System.Windows.Forms.GroupBox gbInkArea;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.TextBox txtResults;
		private System.ComponentModel.Container components = null;
        #endregion

        /// <summary>
        /// Initialize the form and ink collector
        /// </summary>
		public InkRecognition()
		{
            #region Standard Template Code
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            #endregion
           
        }

        #region Standard Template Code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
            fs.Dispose();
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        #endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gbInkArea = new System.Windows.Forms.GroupBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gbInkArea
            // 
            this.gbInkArea.Location = new System.Drawing.Point(10, 0);
            this.gbInkArea.Name = "gbInkArea";
            this.gbInkArea.Size = new System.Drawing.Size(336, 146);
            this.gbInkArea.TabIndex = 0;
            this.gbInkArea.TabStop = false;
            this.gbInkArea.Text = "Ink Here";
            this.gbInkArea.Enter += new System.EventHandler(this.gbInkArea_Enter);
            // 
            // btnRecognize
            //
            this.btnRecognize.Location = new System.Drawing.Point(10, 155);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(336, 25);
            this.btnRecognize.TabIndex = 1;
            this.btnRecognize.Text = "Recognize Ink";
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Window;
            this.txtResults.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResults.Location = new System.Drawing.Point(10, 190);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(336, 21);
            this.txtResults.TabIndex = 2;
            // 
            // InkRecognition
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(357, 239);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.gbInkArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InkRecognition";
            this.Text = "크아아악";
            this.Load += new System.EventHandler(this.InkRecognition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
		#endregion

        /// <summary>
        /// Event Handler from Form Load Event
        /// Setup the ink collector for collection
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void InkRecognition_Load(object sender, System.EventArgs e)
        {
            // Create the recognizers collection
            myRecognizers = new Recognizers();

            // Create a new ink collector that uses the group box handle
            myInkCollector = new InkCollector(gbInkArea.Handle);

            // Turn the ink collector on
            myInkCollector.Enabled = true;
        }

        /// <summary>
        /// Event Handle recognize button click event
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnRecognize_Click(object sender, System.EventArgs e)
        {
            // Check to ensure that the user has at least one recognizer installed
            // Note that this is a preventive check - otherwise, an exception will
            // occur during recognition.
            if (0 == myRecognizers.Count)
            {
                MessageBox.Show("There are no handwriting recognizers installed.  You need to have at least one in order to recognize ink.");
            }
            else
            {

                // Note that the Strokes' ToString() method is a 
                // shortcut  for retrieving the best match using the  
                // default recognizer.  The same result can also be 
                // obtained using the RecognizerContext.  For an 
                // example, uncomment the following lines of code:
                // 
                // RecognizerContext myRecoContext = new RecognizerContext();
                // RecognitionStatus status;
                // RecognitionResult recoResult;
                //
                // myRecoContext.Strokes = myInkCollector.Ink.Strokes;
                // recoResult = myRecoContext.Recognize(out status);
                // txtResults.SelectedText = recoResult.TopString;
                //

                txtResults.SelectedText = myInkCollector.Ink.Strokes.ToString();
                a = myInkCollector.Ink.Strokes.ToString();

                Jonsulp.MainForm temp = (Jonsulp.MainForm)this.Owner;
                temp.text_input.Text = a;

                //이 a스트링 활용하면댐
                // If the mouse is pressed, do not perform the deletion - 
                // this prevents deleting a stroke that is still being drawn
                if (!myInkCollector.CollectingInk)
                {
                    // Once the strokes have been recognized, delete them
                    myInkCollector.Ink.DeleteStrokes();

                    // Repaint the drawing area
                    gbInkArea.Refresh();
                }
            }
        }

        private void gbInkArea_Enter(object sender, EventArgs e)
        {

        }
    }
}
