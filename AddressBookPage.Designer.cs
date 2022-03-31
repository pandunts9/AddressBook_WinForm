
namespace AddressBook
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
            this.warning_label_2 = new System.Windows.Forms.Label();
            this.clear_bt = new System.Windows.Forms.Button();
            this.edit_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.phone_lb = new System.Windows.Forms.Label();
            this.phisycalAddress_tb = new System.Windows.Forms.TextBox();
            this.phisycalAddress_lb = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.email_lb = new System.Windows.Forms.Label();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.contacts_list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warning_label_2
            // 
            this.warning_label_2.AutoSize = true;
            this.warning_label_2.ForeColor = System.Drawing.Color.DarkRed;
            this.warning_label_2.Location = new System.Drawing.Point(429, 275);
            this.warning_label_2.Name = "warning_label_2";
            this.warning_label_2.Size = new System.Drawing.Size(149, 13);
            this.warning_label_2.TabIndex = 67;
            this.warning_label_2.Text = "All fields should be completed!";
            this.warning_label_2.Visible = false;
            // 
            // clear_bt
            // 
            this.clear_bt.BackColor = System.Drawing.Color.Chocolate;
            this.clear_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_bt.Location = new System.Drawing.Point(422, 344);
            this.clear_bt.Name = "clear_bt";
            this.clear_bt.Size = new System.Drawing.Size(68, 30);
            this.clear_bt.TabIndex = 65;
            this.clear_bt.Text = "Clear";
            this.clear_bt.UseCompatibleTextRendering = true;
            this.clear_bt.UseVisualStyleBackColor = false;
            this.clear_bt.Click += new System.EventHandler(this.clear_bt_Click);
            // 
            // edit_bt
            // 
            this.edit_bt.BackColor = System.Drawing.Color.Chocolate;
            this.edit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_bt.Location = new System.Drawing.Point(510, 344);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(68, 30);
            this.edit_bt.TabIndex = 64;
            this.edit_bt.Text = "Edit";
            this.edit_bt.UseCompatibleTextRendering = true;
            this.edit_bt.UseVisualStyleBackColor = false;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.BackColor = System.Drawing.Color.Chocolate;
            this.delete_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bt.Location = new System.Drawing.Point(337, 344);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(68, 30);
            this.delete_bt.TabIndex = 63;
            this.delete_bt.Text = "Delete";
            this.delete_bt.UseVisualStyleBackColor = false;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // add_bt
            // 
            this.add_bt.BackColor = System.Drawing.Color.Chocolate;
            this.add_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bt.Location = new System.Drawing.Point(595, 344);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(68, 30);
            this.add_bt.TabIndex = 62;
            this.add_bt.Text = "Save";
            this.add_bt.UseVisualStyleBackColor = false;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // phone_tb
            // 
            this.phone_tb.BackColor = System.Drawing.Color.Chocolate;
            this.phone_tb.Location = new System.Drawing.Point(432, 242);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(231, 20);
            this.phone_tb.TabIndex = 61;
            this.phone_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_tb_KeyPress);
            // 
            // phone_lb
            // 
            this.phone_lb.BackColor = System.Drawing.Color.Chocolate;
            this.phone_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_lb.Location = new System.Drawing.Point(337, 242);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(89, 20);
            this.phone_lb.TabIndex = 60;
            this.phone_lb.Text = "Phone number";
            this.phone_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phisycalAddress_tb
            // 
            this.phisycalAddress_tb.BackColor = System.Drawing.Color.Chocolate;
            this.phisycalAddress_tb.Location = new System.Drawing.Point(432, 197);
            this.phisycalAddress_tb.Name = "phisycalAddress_tb";
            this.phisycalAddress_tb.Size = new System.Drawing.Size(231, 20);
            this.phisycalAddress_tb.TabIndex = 59;
            // 
            // phisycalAddress_lb
            // 
            this.phisycalAddress_lb.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.phisycalAddress_lb.BackColor = System.Drawing.Color.Chocolate;
            this.phisycalAddress_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phisycalAddress_lb.Location = new System.Drawing.Point(337, 197);
            this.phisycalAddress_lb.Name = "phisycalAddress_lb";
            this.phisycalAddress_lb.Size = new System.Drawing.Size(89, 20);
            this.phisycalAddress_lb.TabIndex = 58;
            this.phisycalAddress_lb.Text = "Physical Address";
            this.phisycalAddress_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.Chocolate;
            this.email_tb.Location = new System.Drawing.Point(432, 157);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(231, 20);
            this.email_tb.TabIndex = 57;
            // 
            // email_lb
            // 
            this.email_lb.BackColor = System.Drawing.Color.Chocolate;
            this.email_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_lb.Location = new System.Drawing.Point(337, 157);
            this.email_lb.Name = "email_lb";
            this.email_lb.Size = new System.Drawing.Size(89, 20);
            this.email_lb.TabIndex = 56;
            this.email_lb.Text = "Email";
            this.email_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastName_tb
            // 
            this.lastName_tb.BackColor = System.Drawing.Color.Chocolate;
            this.lastName_tb.Location = new System.Drawing.Point(432, 118);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(231, 20);
            this.lastName_tb.TabIndex = 55;
            // 
            // lastName_lb
            // 
            this.lastName_lb.BackColor = System.Drawing.Color.Chocolate;
            this.lastName_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastName_lb.Location = new System.Drawing.Point(337, 118);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.Size = new System.Drawing.Size(89, 20);
            this.lastName_lb.TabIndex = 54;
            this.lastName_lb.Text = "Last Name";
            this.lastName_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.Color.Chocolate;
            this.name_tb.Location = new System.Drawing.Point(432, 77);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(231, 20);
            this.name_tb.TabIndex = 53;
            // 
            // name_lbl
            // 
            this.name_lbl.BackColor = System.Drawing.Color.Chocolate;
            this.name_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_lbl.Location = new System.Drawing.Point(337, 77);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(89, 20);
            this.name_lbl.TabIndex = 52;
            this.name_lbl.Text = "Name";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contacts_list
            // 
            this.contacts_list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contacts_list.HideSelection = false;
            this.contacts_list.Location = new System.Drawing.Point(35, 77);
            this.contacts_list.Name = "contacts_list";
            this.contacts_list.Size = new System.Drawing.Size(296, 297);
            this.contacts_list.TabIndex = 51;
            this.contacts_list.UseCompatibleStateImageBehavior = false;
            this.contacts_list.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 55);
            this.label1.TabIndex = 65;
            this.label1.Text = "Address Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(694, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warning_label_2);
            this.Controls.Add(this.clear_bt);
            this.Controls.Add(this.edit_bt);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.phone_lb);
            this.Controls.Add(this.phisycalAddress_tb);
            this.Controls.Add(this.phisycalAddress_lb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.email_lb);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.lastName_lb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.contacts_list);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label warning_label_2;
        private System.Windows.Forms.Button clear_bt;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.Label phone_lb;
        private System.Windows.Forms.TextBox phisycalAddress_tb;
        private System.Windows.Forms.Label phisycalAddress_lb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label email_lb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.ListView contacts_list;
        private System.Windows.Forms.Label label1;
    }
}

