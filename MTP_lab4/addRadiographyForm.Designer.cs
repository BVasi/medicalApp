
namespace MTP_lab4
{
    partial class addRadiographyForm
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
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.pictureSelection = new System.Windows.Forms.Button();
            this.diagnosticLabel = new System.Windows.Forms.Label();
            this.diagnosticTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(93, 10);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.ReadOnly = true;
            this.cnpTextBox.Size = new System.Drawing.Size(199, 22);
            this.cnpTextBox.TabIndex = 0;
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(49, 15);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(36, 17);
            this.cnpLabel.TabIndex = 1;
            this.cnpLabel.Text = "CNP";
            // 
            // dateTextBox
            // 
            this.dateTextBox.AutoSize = true;
            this.dateTextBox.Location = new System.Drawing.Point(49, 43);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(38, 17);
            this.dateTextBox.TabIndex = 2;
            this.dateTextBox.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Location = new System.Drawing.Point(30, 69);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(57, 17);
            this.pictureLabel.TabIndex = 4;
            this.pictureLabel.Text = "Imagine";
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Location = new System.Drawing.Point(93, 66);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.ReadOnly = true;
            this.pictureTextBox.Size = new System.Drawing.Size(199, 22);
            this.pictureTextBox.TabIndex = 5;
            // 
            // pictureSelection
            // 
            this.pictureSelection.Location = new System.Drawing.Point(298, 66);
            this.pictureSelection.Name = "pictureSelection";
            this.pictureSelection.Size = new System.Drawing.Size(75, 23);
            this.pictureSelection.TabIndex = 6;
            this.pictureSelection.Text = "...";
            this.pictureSelection.UseVisualStyleBackColor = true;
            this.pictureSelection.Click += new System.EventHandler(this.pictureSelection_Click);
            // 
            // diagnosticLabel
            // 
            this.diagnosticLabel.AutoSize = true;
            this.diagnosticLabel.Location = new System.Drawing.Point(11, 97);
            this.diagnosticLabel.Name = "diagnosticLabel";
            this.diagnosticLabel.Size = new System.Drawing.Size(74, 17);
            this.diagnosticLabel.TabIndex = 7;
            this.diagnosticLabel.Text = "Diagnostic";
            // 
            // diagnosticTextBox
            // 
            this.diagnosticTextBox.Location = new System.Drawing.Point(93, 94);
            this.diagnosticTextBox.Name = "diagnosticTextBox";
            this.diagnosticTextBox.Size = new System.Drawing.Size(199, 22);
            this.diagnosticTextBox.TabIndex = 8;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(11, 125);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(75, 17);
            this.commentLabel.TabIndex = 9;
            this.commentLabel.Text = "Comentarii";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(94, 122);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(199, 22);
            this.commentTextBox.TabIndex = 10;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(14, 156);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 42);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(214, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 42);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addRadiographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 210);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.diagnosticTextBox);
            this.Controls.Add(this.diagnosticLabel);
            this.Controls.Add(this.pictureSelection);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.cnpTextBox);
            this.Name = "addRadiographyForm";
            this.Text = "addRadiographyForm";
            this.Load += new System.EventHandler(this.addRadiographyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.Label dateTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Button pictureSelection;
        private System.Windows.Forms.Label diagnosticLabel;
        private System.Windows.Forms.TextBox diagnosticTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}