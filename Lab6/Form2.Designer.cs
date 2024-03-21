namespace Lab6
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtItemNo = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 87);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 181);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 261);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // txtItemNo
            // 
            txtItemNo.Location = new Point(204, 87);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(175, 27);
            txtItemNo.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(204, 178);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(175, 27);
            txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(204, 258);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(233, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(474, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtItemNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtItemNo;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}