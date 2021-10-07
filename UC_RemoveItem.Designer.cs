
namespace RestaurantManagementSystem
{
    partial class UC_RemoveItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchRemoveItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRemoveItem = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveItem)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Item";
            // 
            // txtSearchRemoveItem
            // 
            this.txtSearchRemoveItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRemoveItem.DefaultText = "";
            this.txtSearchRemoveItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchRemoveItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchRemoveItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRemoveItem.DisabledState.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRemoveItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRemoveItem.FocusedState.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRemoveItem.HoverState.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.Location = new System.Drawing.Point(267, 104);
            this.txtSearchRemoveItem.Name = "txtSearchRemoveItem";
            this.txtSearchRemoveItem.PasswordChar = '\0';
            this.txtSearchRemoveItem.PlaceholderText = "Search Here";
            this.txtSearchRemoveItem.SelectedText = "";
            this.txtSearchRemoveItem.ShadowDecoration.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.Size = new System.Drawing.Size(231, 37);
            this.txtSearchRemoveItem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchRemoveItem.TabIndex = 2;
            this.txtSearchRemoveItem.TextChanged += new System.EventHandler(this.txtSearchRemoveItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(262, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Name";
            // 
            // dataGridViewRemoveItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridViewRemoveItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRemoveItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRemoveItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRemoveItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRemoveItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRemoveItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRemoveItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRemoveItem.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRemoveItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRemoveItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRemoveItem.EnableHeadersVisualStyles = false;
            this.dataGridViewRemoveItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridViewRemoveItem.Location = new System.Drawing.Point(6, 176);
            this.dataGridViewRemoveItem.Name = "dataGridViewRemoveItem";
            this.dataGridViewRemoveItem.RowHeadersVisible = false;
            this.dataGridViewRemoveItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRemoveItem.Size = new System.Drawing.Size(772, 291);
            this.dataGridViewRemoveItem.TabIndex = 5;
            this.dataGridViewRemoveItem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dataGridViewRemoveItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridViewRemoveItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRemoveItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRemoveItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRemoveItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRemoveItem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRemoveItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridViewRemoveItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dataGridViewRemoveItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRemoveItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewRemoveItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRemoveItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewRemoveItem.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewRemoveItem.ThemeStyle.ReadOnly = false;
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dataGridViewRemoveItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewRemoveItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRemoveItem_CellClick);
            // 
            // UC_RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewRemoveItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchRemoveItem);
            this.Controls.Add(this.label1);
            this.Name = "UC_RemoveItem";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_RemoveItem_Load);
            this.Enter += new System.EventHandler(this.UC_RemoveItem_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRemoveItem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchRemoveItem;
        private System.Windows.Forms.Label label1;
    }
}
