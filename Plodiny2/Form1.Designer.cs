namespace Plodiny2
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
            button1 = new Button();
            daysLabel = new Label();
            plodinaView1 = new PlodinaView();
            plodinaView2 = new PlodinaView();
            plodinaView3 = new PlodinaView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(347, 384);
            button1.Name = "button1";
            button1.Size = new Size(312, 242);
            button1.TabIndex = 0;
            button1.Text = "Click me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            daysLabel.Location = new Point(12, 9);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new Size(115, 48);
            daysLabel.TabIndex = 1;
            daysLabel.Text = "label1";
            // 
            // plodinaView1
            // 
            plodinaView1.BorderStyle = BorderStyle.FixedSingle;
            plodinaView1.Location = new Point(29, 69);
            plodinaView1.Name = "plodinaView1";
            plodinaView1.Size = new Size(350, 459);
            plodinaView1.TabIndex = 2;
            // 
            // plodinaView2
            // 
            plodinaView2.BorderStyle = BorderStyle.FixedSingle;
            plodinaView2.Location = new Point(385, 69);
            plodinaView2.Name = "plodinaView2";
            plodinaView2.Size = new Size(350, 459);
            plodinaView2.TabIndex = 3;
            // 
            // plodinaView3
            // 
            plodinaView3.BorderStyle = BorderStyle.FixedSingle;
            plodinaView3.Location = new Point(741, 69);
            plodinaView3.Name = "plodinaView3";
            plodinaView3.Size = new Size(350, 459);
            plodinaView3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 696);
            Controls.Add(plodinaView3);
            Controls.Add(plodinaView2);
            Controls.Add(plodinaView1);
            Controls.Add(daysLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label daysLabel;
        private PlodinaView plodinaView1;
        private PlodinaView plodinaView2;
        private PlodinaView plodinaView3;
    }
}
