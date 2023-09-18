namespace BasicQueueCashier
{
    partial class CashierWindowQueueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnRefresh = new Button();
            btnNext = new Button();
            imageList1 = new ImageList(components);
            listCashierQueue = new ListBox();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(12, 56);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGray;
            btnNext.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(12, 109);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(95, 33);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BackColor = SystemColors.Info;
            listCashierQueue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 21;
            listCashierQueue.Location = new Point(170, 45);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(198, 340);
            listCashierQueue.TabIndex = 2;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(423, 450);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ImageList imageList1;
        private ListBox listCashierQueue;
    }
}