namespace Memoria_Dinamica_2
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
            BtnSize = new Button();
            BtnAdd = new Button();
            UpDowVectorSize = new DomainUpDown();
            label1 = new Label();
            TexboxData = new TextBox();
            LstBoxVector = new ListBox();
            lblSize = new Label();
            SuspendLayout();
            // 
            // BtnSize
            // 
            BtnSize.Location = new Point(29, 64);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(75, 23);
            BtnSize.TabIndex = 0;
            BtnSize.Text = "Insert";
            BtnSize.UseVisualStyleBackColor = true;
            BtnSize.Click += BtnSize_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(29, 162);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "button2";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // UpDowVectorSize
            // 
            UpDowVectorSize.Items.Add("1");
            UpDowVectorSize.Items.Add("2");
            UpDowVectorSize.Items.Add("3");
            UpDowVectorSize.Items.Add("4");
            UpDowVectorSize.Items.Add("5");
            UpDowVectorSize.Items.Add("6");
            UpDowVectorSize.Items.Add("7");
            UpDowVectorSize.Items.Add("8");
            UpDowVectorSize.Items.Add("9");
            UpDowVectorSize.Location = new Point(139, 64);
            UpDowVectorSize.Name = "UpDowVectorSize";
            UpDowVectorSize.ReadOnly = true;
            UpDowVectorSize.Size = new Size(120, 23);
            UpDowVectorSize.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Tamaño del Vector";
            // 
            // TexboxData
            // 
            TexboxData.Location = new Point(139, 162);
            TexboxData.Name = "TexboxData";
            TexboxData.Size = new Size(155, 23);
            TexboxData.TabIndex = 4;
            // 
            // LstBoxVector
            // 
            LstBoxVector.FormattingEnabled = true;
            LstBoxVector.ItemHeight = 15;
            LstBoxVector.Location = new Point(372, 12);
            LstBoxVector.Name = "LstBoxVector";
            LstBoxVector.Size = new Size(128, 394);
            LstBoxVector.TabIndex = 5;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(139, 28);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 15);
            lblSize.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(lblSize);
            Controls.Add(LstBoxVector);
            Controls.Add(TexboxData);
            Controls.Add(label1);
            Controls.Add(UpDowVectorSize);
            Controls.Add(BtnAdd);
            Controls.Add(BtnSize);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSize;
        private Button BtnAdd;
        private DomainUpDown UpDowVectorSize;
        private Label label1;
        private TextBox TexboxData;
        private ListBox LstBoxVector;
        private Label lblSize;
    }
}
