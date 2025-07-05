namespace SerialSend
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
            btnList = new Button();
            btnOpen = new Button();
            btnClose = new Button();
            comboPorts = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textD1 = new TextBox();
            textD2 = new TextBox();
            btnSend = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(33, 22);
            btnList.Name = "btnList";
            btnList.Size = new Size(95, 39);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(33, 96);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(95, 39);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(197, 96);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 39);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // comboPorts
            // 
            comboPorts.FormattingEnabled = true;
            comboPorts.Location = new Point(197, 28);
            comboPorts.Name = "comboPorts";
            comboPorts.Size = new Size(95, 28);
            comboPorts.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 149);
            label1.Name = "label1";
            label1.Size = new Size(351, 20);
            label1.TabIndex = 4;
            label1.Text = "---------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 195);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 5;
            label2.Text = "D1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 195);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 6;
            label3.Text = "D2";
            // 
            // textD1
            // 
            textD1.Location = new Point(67, 192);
            textD1.Name = "textD1";
            textD1.Size = new Size(78, 27);
            textD1.TabIndex = 7;
            textD1.TextChanged += textBox1_TextChanged;
            // 
            // textD2
            // 
            textD2.Location = new Point(214, 192);
            textD2.Name = "textD2";
            textD2.Size = new Size(78, 27);
            textD2.TabIndex = 8;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(126, 254);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(92, 34);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 314);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "Cours POC - Roland Assilevi - 2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 350);
            Controls.Add(label4);
            Controls.Add(btnSend);
            Controls.Add(textD2);
            Controls.Add(textD1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboPorts);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(btnList);
            Name = "Form1";
            Text = "SerailSend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnList;
        private Button btnOpen;
        private Button btnClose;
        private ComboBox comboPorts;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textD1;
        private TextBox textD2;
        private Button btnSend;
        private Label label4;
    }
}
