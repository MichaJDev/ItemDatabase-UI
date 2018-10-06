namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dbBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.itemStrCheck = new System.Windows.Forms.CheckBox();
            this.itemIntCheck = new System.Windows.Forms.CheckBox();
            this.itemAgilCheck = new System.Windows.Forms.CheckBox();
            this.itemHastCheck = new System.Windows.Forms.CheckBox();
            this.itemMastCheck = new System.Windows.Forms.CheckBox();
            this.itemStamCheck = new System.Windows.Forms.CheckBox();
            this.itemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemWorth = new System.Windows.Forms.ComboBox();
            this.itemInt = new System.Windows.Forms.TextBox();
            this.itemStr = new System.Windows.Forms.TextBox();
            this.itemStam = new System.Windows.Forms.TextBox();
            this.itemMas = new System.Windows.Forms.TextBox();
            this.itemHas = new System.Windows.Forms.TextBox();
            this.itemAgi = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbBtn
            // 
            this.dbBtn.Location = new System.Drawing.Point(18, 302);
            this.dbBtn.Name = "dbBtn";
            this.dbBtn.Size = new System.Drawing.Size(75, 23);
            this.dbBtn.TabIndex = 0;
            this.dbBtn.Text = "Database";
            this.dbBtn.UseVisualStyleBackColor = true;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(197, 302);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // itemStrCheck
            // 
            this.itemStrCheck.AutoSize = true;
            this.itemStrCheck.Location = new System.Drawing.Point(157, 192);
            this.itemStrCheck.Name = "itemStrCheck";
            this.itemStrCheck.Size = new System.Drawing.Size(66, 17);
            this.itemStrCheck.TabIndex = 2;
            this.itemStrCheck.Text = "Strength";
            this.itemStrCheck.UseVisualStyleBackColor = true;
            // 
            // itemIntCheck
            // 
            this.itemIntCheck.AutoSize = true;
            this.itemIntCheck.Location = new System.Drawing.Point(157, 212);
            this.itemIntCheck.Name = "itemIntCheck";
            this.itemIntCheck.Size = new System.Drawing.Size(63, 17);
            this.itemIntCheck.TabIndex = 3;
            this.itemIntCheck.Text = "Intellect";
            this.itemIntCheck.UseVisualStyleBackColor = true;
            // 
            // itemAgilCheck
            // 
            this.itemAgilCheck.AutoSize = true;
            this.itemAgilCheck.Location = new System.Drawing.Point(157, 235);
            this.itemAgilCheck.Name = "itemAgilCheck";
            this.itemAgilCheck.Size = new System.Drawing.Size(53, 17);
            this.itemAgilCheck.TabIndex = 4;
            this.itemAgilCheck.Text = "Agility";
            this.itemAgilCheck.UseVisualStyleBackColor = true;
            // 
            // itemHastCheck
            // 
            this.itemHastCheck.AutoSize = true;
            this.itemHastCheck.Location = new System.Drawing.Point(157, 257);
            this.itemHastCheck.Name = "itemHastCheck";
            this.itemHastCheck.Size = new System.Drawing.Size(54, 17);
            this.itemHastCheck.TabIndex = 5;
            this.itemHastCheck.Text = "Haste";
            this.itemHastCheck.UseVisualStyleBackColor = true;
            // 
            // itemMastCheck
            // 
            this.itemMastCheck.AutoSize = true;
            this.itemMastCheck.Location = new System.Drawing.Point(157, 277);
            this.itemMastCheck.Name = "itemMastCheck";
            this.itemMastCheck.Size = new System.Drawing.Size(63, 17);
            this.itemMastCheck.TabIndex = 6;
            this.itemMastCheck.Text = "Mastery";
            this.itemMastCheck.UseVisualStyleBackColor = true;
            // 
            // itemStamCheck
            // 
            this.itemStamCheck.AutoSize = true;
            this.itemStamCheck.Location = new System.Drawing.Point(157, 169);
            this.itemStamCheck.Name = "itemStamCheck";
            this.itemStamCheck.Size = new System.Drawing.Size(64, 17);
            this.itemStamCheck.TabIndex = 7;
            this.itemStamCheck.Text = "Stamina";
            this.itemStamCheck.UseVisualStyleBackColor = true;
            // 
            // itemType
            // 
            this.itemType.FormattingEnabled = true;
            this.itemType.Items.AddRange(new object[] {
            "Head",
            "Shoulders",
            "Chest",
            "Hands",
            "Waist",
            "Legs",
            "Boots",
            "Shield",
            "1 Handed Sword",
            "2 Handed Sword",
            "1 Handed Mace",
            "2 Handed Mace",
            "Bow",
            "Rifle"});
            this.itemType.Location = new System.Drawing.Point(18, 188);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(121, 21);
            this.itemType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item Worth";
            // 
            // itemWorth
            // 
            this.itemWorth.FormattingEnabled = true;
            this.itemWorth.Items.AddRange(new object[] {
            "Poor",
            "Common",
            "Uncommon",
            "Rare",
            "Epic",
            "Legendary",
            "Artifact",
            "Heirloom"});
            this.itemWorth.Location = new System.Drawing.Point(18, 238);
            this.itemWorth.Name = "itemWorth";
            this.itemWorth.Size = new System.Drawing.Size(121, 21);
            this.itemWorth.TabIndex = 10;
            // 
            // itemInt
            // 
            this.itemInt.Location = new System.Drawing.Point(229, 210);
            this.itemInt.Name = "itemInt";
            this.itemInt.Size = new System.Drawing.Size(43, 20);
            this.itemInt.TabIndex = 17;
            this.itemInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemInt_KeyPress);
            // 
            // itemStr
            // 
            this.itemStr.Location = new System.Drawing.Point(229, 188);
            this.itemStr.Name = "itemStr";
            this.itemStr.Size = new System.Drawing.Size(43, 20);
            this.itemStr.TabIndex = 16;
            this.itemStr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemStr_KeyPress);
            // 
            // itemStam
            // 
            this.itemStam.Location = new System.Drawing.Point(229, 166);
            this.itemStam.Name = "itemStam";
            this.itemStam.Size = new System.Drawing.Size(43, 20);
            this.itemStam.TabIndex = 15;
            this.itemStam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemStam_KeyPress);
            // 
            // itemMas
            // 
            this.itemMas.Location = new System.Drawing.Point(229, 276);
            this.itemMas.Name = "itemMas";
            this.itemMas.Size = new System.Drawing.Size(43, 20);
            this.itemMas.TabIndex = 20;
            this.itemMas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemMas_KeyPress);
            // 
            // itemHas
            // 
            this.itemHas.Location = new System.Drawing.Point(229, 254);
            this.itemHas.Name = "itemHas";
            this.itemHas.Size = new System.Drawing.Size(43, 20);
            this.itemHas.TabIndex = 19;
            this.itemHas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemHas_KeyPress);
            // 
            // itemAgi
            // 
            this.itemAgi.Location = new System.Drawing.Point(229, 232);
            this.itemAgi.Name = "itemAgi";
            this.itemAgi.Size = new System.Drawing.Size(43, 20);
            this.itemAgi.TabIndex = 18;
            this.itemAgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemAgi_KeyPress);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(18, 88);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(254, 20);
            this.itemName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Item Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Item Name";
            // 
            // itemDesc
            // 
            this.itemDesc.Location = new System.Drawing.Point(18, 127);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(254, 20);
            this.itemDesc.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemMas);
            this.Controls.Add(this.itemHas);
            this.Controls.Add(this.itemAgi);
            this.Controls.Add(this.itemInt);
            this.Controls.Add(this.itemStr);
            this.Controls.Add(this.itemStam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemWorth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.itemStamCheck);
            this.Controls.Add(this.itemMastCheck);
            this.Controls.Add(this.itemHastCheck);
            this.Controls.Add(this.itemAgilCheck);
            this.Controls.Add(this.itemIntCheck);
            this.Controls.Add(this.itemStrCheck);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.dbBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dbBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.CheckBox itemStrCheck;
        private System.Windows.Forms.CheckBox itemIntCheck;
        private System.Windows.Forms.CheckBox itemAgilCheck;
        private System.Windows.Forms.CheckBox itemHastCheck;
        private System.Windows.Forms.CheckBox itemMastCheck;
        private System.Windows.Forms.CheckBox itemStamCheck;
        private System.Windows.Forms.ComboBox itemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemWorth;
        private System.Windows.Forms.TextBox itemInt;
        private System.Windows.Forms.TextBox itemStr;
        private System.Windows.Forms.TextBox itemStam;
        private System.Windows.Forms.TextBox itemMas;
        private System.Windows.Forms.TextBox itemHas;
        private System.Windows.Forms.TextBox itemAgi;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

