namespace Ivan_Angelov_Working
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
            buttonRead = new Button();
            buttonStatistics = new Button();
            buttonWrite = new Button();
            textBoxContent = new TextBox();
            textBoxData = new TextBox();
            SuspendLayout();
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(59, 65);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(153, 89);
            buttonRead.TabIndex = 0;
            buttonRead.Text = "Зареди Файл";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.Location = new Point(59, 168);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(153, 86);
            buttonStatistics.TabIndex = 1;
            buttonStatistics.Text = "Статистика";
            buttonStatistics.UseVisualStyleBackColor = true;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(59, 295);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(153, 86);
            buttonWrite.TabIndex = 2;
            buttonWrite.Text = "Запиши статистиките във файл";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(430, 127);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.ReadOnly = true;
            textBoxContent.Size = new Size(110, 50);
            textBoxContent.TabIndex = 3;
            textBoxContent.TextChanged += textBoxContent_TextChanged;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(430, 216);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.ReadOnly = true;
            textBoxData.Size = new Size(110, 51);
            textBoxData.TabIndex = 4;
            textBoxData.TextChanged += textBoxData_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxData);
            Controls.Add(textBoxContent);
            Controls.Add(buttonWrite);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonRead);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRead;
        private Button buttonStatistics;
        private Button buttonWrite;
        private TextBox textBoxContent;
        private TextBox textBoxData;
    }
}