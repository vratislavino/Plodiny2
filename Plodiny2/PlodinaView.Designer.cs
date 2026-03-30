namespace Plodiny2
{
    partial class PlodinaView
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 11);
            label1.Name = "label1";
            label1.Size = new Size(235, 53);
            label1.TabIndex = 0;
            label1.Text = "Hovezi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(232, 43);
            label2.TabIndex = 1;
            label2.Text = "Česko";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 92);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.BackColor = Color.Coral;
            label4.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(121, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 92);
            label4.TabIndex = 1;
            label4.Text = "1";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 92);
            label3.TabIndex = 0;
            label3.Text = "1";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Location = new Point(20, 211);
            button1.Name = "button1";
            button1.Size = new Size(89, 84);
            button1.TabIndex = 3;
            button1.Text = "Zalít";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(124, 211);
            button2.Name = "button2";
            button2.Size = new Size(89, 84);
            button2.TabIndex = 4;
            button2.Text = "Sklidit";
            button2.UseVisualStyleBackColor = true;
            // 
            // PlodinaView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PlodinaView";
            Size = new Size(233, 306);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
