namespace Joe_sGarage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOilLube = new GroupBox();
            checkBoxOilChange = new CheckBox();
            checkBoxLubeJob = new CheckBox();
            groupBoxFlush = new GroupBox();
            checkBoxTransFlush = new CheckBox();
            checkBoxRadiatorFlush = new CheckBox();
            groupBoxMisc = new GroupBox();
            checkBoxTire = new CheckBox();
            checkBoxMuffler = new CheckBox();
            checkBoxInspection = new CheckBox();
            groupBoxPandL = new GroupBox();
            textBoxParts = new TextBox();
            textBoxLabor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBoxSummary = new GroupBox();
            totalOutput = new Label();
            taxOutput = new Label();
            partsOutput = new Label();
            serviceAndLaborOutput = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonCalculate = new Button();
            button2 = new Button();
            buttonExit = new Button();
            groupBoxOilLube.SuspendLayout();
            groupBoxFlush.SuspendLayout();
            groupBoxMisc.SuspendLayout();
            groupBoxPandL.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOilLube
            // 
            groupBoxOilLube.Controls.Add(checkBoxOilChange);
            groupBoxOilLube.Controls.Add(checkBoxLubeJob);
            groupBoxOilLube.Location = new Point(12, 12);
            groupBoxOilLube.Name = "groupBoxOilLube";
            groupBoxOilLube.Size = new Size(165, 78);
            groupBoxOilLube.TabIndex = 0;
            groupBoxOilLube.TabStop = false;
            groupBoxOilLube.Text = "Oil and Lube";
            // 
            // checkBoxOilChange
            // 
            checkBoxOilChange.AutoSize = true;
            checkBoxOilChange.Location = new Point(6, 22);
            checkBoxOilChange.Name = "checkBoxOilChange";
            checkBoxOilChange.Size = new Size(129, 19);
            checkBoxOilChange.TabIndex = 1;
            checkBoxOilChange.Text = "Oil Change ($26.00)";
            checkBoxOilChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxLubeJob
            // 
            checkBoxLubeJob.AutoSize = true;
            checkBoxLubeJob.Location = new Point(6, 47);
            checkBoxLubeJob.Name = "checkBoxLubeJob";
            checkBoxLubeJob.Size = new Size(117, 19);
            checkBoxLubeJob.TabIndex = 2;
            checkBoxLubeJob.Text = "Lube Job ($18.00)";
            checkBoxLubeJob.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlush
            // 
            groupBoxFlush.Controls.Add(checkBoxTransFlush);
            groupBoxFlush.Controls.Add(checkBoxRadiatorFlush);
            groupBoxFlush.Location = new Point(187, 12);
            groupBoxFlush.Name = "groupBoxFlush";
            groupBoxFlush.Size = new Size(179, 78);
            groupBoxFlush.TabIndex = 1;
            groupBoxFlush.TabStop = false;
            groupBoxFlush.Text = "Flushes";
            // 
            // checkBoxTransFlush
            // 
            checkBoxTransFlush.AutoSize = true;
            checkBoxTransFlush.Location = new Point(6, 44);
            checkBoxTransFlush.Name = "checkBoxTransFlush";
            checkBoxTransFlush.Size = new Size(169, 19);
            checkBoxTransFlush.TabIndex = 1;
            checkBoxTransFlush.Text = "Transmission Flush ($80.00)";
            checkBoxTransFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadiatorFlush
            // 
            checkBoxRadiatorFlush.AutoSize = true;
            checkBoxRadiatorFlush.Location = new Point(6, 19);
            checkBoxRadiatorFlush.Name = "checkBoxRadiatorFlush";
            checkBoxRadiatorFlush.Size = new Size(145, 19);
            checkBoxRadiatorFlush.TabIndex = 0;
            checkBoxRadiatorFlush.Text = "Radiator Flush ($30.00)";
            checkBoxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisc
            // 
            groupBoxMisc.Controls.Add(checkBoxTire);
            groupBoxMisc.Controls.Add(checkBoxMuffler);
            groupBoxMisc.Controls.Add(checkBoxInspection);
            groupBoxMisc.Location = new Point(12, 96);
            groupBoxMisc.Name = "groupBoxMisc";
            groupBoxMisc.Size = new Size(166, 100);
            groupBoxMisc.TabIndex = 2;
            groupBoxMisc.TabStop = false;
            groupBoxMisc.Text = "Misc";
            // 
            // checkBoxTire
            // 
            checkBoxTire.AutoSize = true;
            checkBoxTire.Location = new Point(6, 69);
            checkBoxTire.Name = "checkBoxTire";
            checkBoxTire.Size = new Size(137, 19);
            checkBoxTire.TabIndex = 2;
            checkBoxTire.Text = "Tire Rotation ($20.00)";
            checkBoxTire.UseVisualStyleBackColor = true;
            // 
            // checkBoxMuffler
            // 
            checkBoxMuffler.AutoSize = true;
            checkBoxMuffler.Location = new Point(6, 44);
            checkBoxMuffler.Name = "checkBoxMuffler";
            checkBoxMuffler.Size = new Size(159, 19);
            checkBoxMuffler.TabIndex = 1;
            checkBoxMuffler.Text = "Replace Muffler ($100.00)";
            checkBoxMuffler.UseVisualStyleBackColor = true;
            // 
            // checkBoxInspection
            // 
            checkBoxInspection.AutoSize = true;
            checkBoxInspection.Location = new Point(6, 19);
            checkBoxInspection.Name = "checkBoxInspection";
            checkBoxInspection.Size = new Size(125, 19);
            checkBoxInspection.TabIndex = 0;
            checkBoxInspection.Text = "Inspection ($15.00)";
            checkBoxInspection.UseVisualStyleBackColor = true;
            // 
            // groupBoxPandL
            // 
            groupBoxPandL.Controls.Add(textBoxParts);
            groupBoxPandL.Controls.Add(textBoxLabor);
            groupBoxPandL.Controls.Add(label1);
            groupBoxPandL.Controls.Add(label2);
            groupBoxPandL.Location = new Point(187, 96);
            groupBoxPandL.Name = "groupBoxPandL";
            groupBoxPandL.Size = new Size(179, 100);
            groupBoxPandL.TabIndex = 3;
            groupBoxPandL.TabStop = false;
            groupBoxPandL.Text = "Parts and Labor";
            // 
            // textBoxParts
            // 
            textBoxParts.Location = new Point(83, 24);
            textBoxParts.Name = "textBoxParts";
            textBoxParts.Size = new Size(68, 23);
            textBoxParts.TabIndex = 4;
            // 
            // textBoxLabor
            // 
            textBoxLabor.Location = new Point(83, 61);
            textBoxLabor.Name = "textBoxLabor";
            textBoxLabor.Size = new Size(68, 23);
            textBoxLabor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Parts: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Labor ($):";
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(totalOutput);
            groupBoxSummary.Controls.Add(taxOutput);
            groupBoxSummary.Controls.Add(partsOutput);
            groupBoxSummary.Controls.Add(serviceAndLaborOutput);
            groupBoxSummary.Controls.Add(label3);
            groupBoxSummary.Controls.Add(label4);
            groupBoxSummary.Controls.Add(label5);
            groupBoxSummary.Controls.Add(label6);
            groupBoxSummary.Location = new Point(12, 202);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(354, 163);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "Summary";
            // 
            // totalOutput
            // 
            totalOutput.BorderStyle = BorderStyle.Fixed3D;
            totalOutput.Location = new Point(127, 116);
            totalOutput.Name = "totalOutput";
            totalOutput.Size = new Size(100, 23);
            totalOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            taxOutput.BorderStyle = BorderStyle.Fixed3D;
            taxOutput.Location = new Point(127, 88);
            taxOutput.Name = "taxOutput";
            taxOutput.Size = new Size(100, 23);
            taxOutput.TabIndex = 11;
            // 
            // partsOutput
            // 
            partsOutput.BorderStyle = BorderStyle.Fixed3D;
            partsOutput.Location = new Point(127, 60);
            partsOutput.Name = "partsOutput";
            partsOutput.Size = new Size(100, 23);
            partsOutput.TabIndex = 10;
            // 
            // serviceAndLaborOutput
            // 
            serviceAndLaborOutput.BorderStyle = BorderStyle.Fixed3D;
            serviceAndLaborOutput.Location = new Point(127, 34);
            serviceAndLaborOutput.Name = "serviceAndLaborOutput";
            serviceAndLaborOutput.Size = new Size(100, 23);
            serviceAndLaborOutput.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 42);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Service and Labor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 68);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Parts:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 96);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 7;
            label5.Text = "Tax (on parts):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 124);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 8;
            label6.Text = "Total Fees:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 371);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(108, 23);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(139, 371);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(270, 371);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(96, 23);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 405);
            Controls.Add(buttonExit);
            Controls.Add(button2);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBoxSummary);
            Controls.Add(groupBoxPandL);
            Controls.Add(groupBoxMisc);
            Controls.Add(groupBoxFlush);
            Controls.Add(groupBoxOilLube);
            Name = "Form1";
            Text = "Joe's Garage";
            groupBoxOilLube.ResumeLayout(false);
            groupBoxOilLube.PerformLayout();
            groupBoxFlush.ResumeLayout(false);
            groupBoxFlush.PerformLayout();
            groupBoxMisc.ResumeLayout(false);
            groupBoxMisc.PerformLayout();
            groupBoxPandL.ResumeLayout(false);
            groupBoxPandL.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOilLube;
        private CheckBox checkBoxOilChange;
        private CheckBox checkBoxLubeJob;
        private GroupBox groupBoxFlush;
        private CheckBox checkBoxTransFlush;
        private CheckBox checkBoxRadiatorFlush;
        private GroupBox groupBoxMisc;
        private CheckBox checkBoxTire;
        private CheckBox checkBoxMuffler;
        private CheckBox checkBoxInspection;
        private GroupBox groupBoxPandL;
        private TextBox textBoxParts;
        private TextBox textBoxLabor;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxSummary;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label totalOutput;
        private Label taxOutput;
        private Label partsOutput;
        private Label serviceAndLaborOutput;
        private Button buttonCalculate;
        private Button button2;
        private Button buttonExit;
    }
}
