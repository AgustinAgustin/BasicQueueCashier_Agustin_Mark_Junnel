namespace BasicQueueCashier
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.LightGray;
            btnCashier.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(31, 48);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(143, 124);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Consolas", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(236, 111);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(255, 37);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "______________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(213, 48);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 2;
            label1.Text = "Position in Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(252, 23);
            label2.TabIndex = 3;
            label2.Text = "*Click to get a number";
            label2.Click += label2_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(530, 263);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label1;
        private Label label2;
    }
}