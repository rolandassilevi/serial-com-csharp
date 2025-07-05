namespace SerialReceive
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
            comboPorts = new ComboBox();
            btnOpen = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            textD1 = new TextBox();
            textD2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(48, 49);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // comboPorts
            // 
            comboPorts.FormattingEnabled = true;
            comboPorts.Location = new Point(205, 49);
            comboPorts.Name = "comboPorts";
            comboPorts.Size = new Size(94, 28);
            comboPorts.TabIndex = 1;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(48, 118);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(205, 118);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 178);
            label1.Name = "label1";
            label1.Size = new Size(339, 20);
            label1.TabIndex = 4;
            label1.Text = "-------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 219);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 5;
            label2.Text = "D1";
            // 
            // textD1
            // 
            textD1.Location = new Point(85, 216);
            textD1.Name = "textD1";
            textD1.Size = new Size(63, 27);
            textD1.TabIndex = 6;
            // 
            // textD2
            // 
            textD2.Location = new Point(236, 219);
            textD2.Name = "textD2";
            textD2.Size = new Size(63, 27);
            textD2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 222);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 7;
            label3.Text = "D2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 287);
            label4.Name = "label4";
            label4.Size = new Size(238, 20);
            label4.TabIndex = 9;
            label4.Text = "Cours POC - Roland Assilevi - 2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 316);
            Controls.Add(label4);
            Controls.Add(textD2);
            Controls.Add(label3);
            Controls.Add(textD1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(comboPorts);
            Controls.Add(btnList);
            Name = "Form1";
            Text = "SerialReceive";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnList;
        private ComboBox comboPorts;
        private Button btnOpen;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private TextBox textD1;
        private TextBox textD2;
        private Label label3;
        private Label label4;
    }
}
