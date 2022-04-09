namespace simple_toDoList_winforms
{
    partial class Form1
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
            this.tbToDo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chklbToDoList = new System.Windows.Forms.CheckedListBox();
            this.btnClearChecked = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblWhatToDo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbToDo
            // 
            this.tbToDo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToDo.Location = new System.Drawing.Point(18, 76);
            this.tbToDo.Multiline = true;
            this.tbToDo.Name = "tbToDo";
            this.tbToDo.Size = new System.Drawing.Size(361, 68);
            this.tbToDo.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(361, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // chklbToDoList
            // 
            this.chklbToDoList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbToDoList.FormattingEnabled = true;
            this.chklbToDoList.Location = new System.Drawing.Point(18, 214);
            this.chklbToDoList.Name = "chklbToDoList";
            this.chklbToDoList.Size = new System.Drawing.Size(361, 284);
            this.chklbToDoList.TabIndex = 2;
            // 
            // btnClearChecked
            // 
            this.btnClearChecked.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearChecked.Location = new System.Drawing.Point(18, 504);
            this.btnClearChecked.Name = "btnClearChecked";
            this.btnClearChecked.Size = new System.Drawing.Size(181, 43);
            this.btnClearChecked.TabIndex = 1;
            this.btnClearChecked.Text = "Clear Checked";
            this.btnClearChecked.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(198, 504);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(181, 43);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // lblWhatToDo
            // 
            this.lblWhatToDo.AutoSize = true;
            this.lblWhatToDo.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatToDo.Location = new System.Drawing.Point(19, 24);
            this.lblWhatToDo.Name = "lblWhatToDo";
            this.lblWhatToDo.Size = new System.Drawing.Size(198, 40);
            this.lblWhatToDo.TabIndex = 3;
            this.lblWhatToDo.Text = "WHAT TO DO?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(397, 564);
            this.Controls.Add(this.lblWhatToDo);
            this.Controls.Add(this.chklbToDoList);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearChecked);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbToDo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "What to do?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox chklbToDoList;
        private System.Windows.Forms.Button btnClearChecked;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblWhatToDo;
    }
}

