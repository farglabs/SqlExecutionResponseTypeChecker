namespace SqlExecutionResponseTypeChecker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.textBoxTestConnectionResult = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxOptions = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBoxOptions);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.textBoxDatabase);
            this.panel1.Controls.Add(this.textBoxServer);
            this.panel1.Controls.Add(this.textBoxTestConnectionResult);
            this.panel1.Controls.Add(this.textBoxConnectionString);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonTestConnection);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 403);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxResponse);
            this.panel2.Controls.Add(this.textBoxSQL);
            this.panel2.Controls.Add(this.buttonExecute);
            this.panel2.Location = new System.Drawing.Point(378, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 403);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Server Connection Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SQL Server Command Execution and Response";
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(7, 206);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(75, 23);
            this.buttonTestConnection.TabIndex = 1;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(7, 206);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Location = new System.Drawing.Point(7, 30);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSQL.Size = new System.Drawing.Size(400, 170);
            this.textBoxSQL.TabIndex = 2;
            this.textBoxSQL.WordWrap = false;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(4, 235);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResponse.Size = new System.Drawing.Size(403, 165);
            this.textBoxResponse.TabIndex = 3;
            this.textBoxResponse.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SQL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Response:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Server Instance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Database:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Other Options:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Connection String:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Connection Test Result:";
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(10, 252);
            this.textBoxConnectionString.Multiline = true;
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.ReadOnly = true;
            this.textBoxConnectionString.Size = new System.Drawing.Size(337, 50);
            this.textBoxConnectionString.TabIndex = 9;
            // 
            // textBoxTestConnectionResult
            // 
            this.textBoxTestConnectionResult.Location = new System.Drawing.Point(10, 339);
            this.textBoxTestConnectionResult.Multiline = true;
            this.textBoxTestConnectionResult.Name = "textBoxTestConnectionResult";
            this.textBoxTestConnectionResult.ReadOnly = true;
            this.textBoxTestConnectionResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTestConnectionResult.Size = new System.Drawing.Size(337, 61);
            this.textBoxTestConnectionResult.TabIndex = 10;
            this.textBoxTestConnectionResult.WordWrap = false;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(99, 12);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(248, 20);
            this.textBoxServer.TabIndex = 11;
            this.textBoxServer.TextChanged += new System.EventHandler(this.updateDSN);
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(99, 48);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(248, 20);
            this.textBoxDatabase.TabIndex = 12;
            this.textBoxDatabase.TextChanged += new System.EventHandler(this.updateDSN);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(99, 87);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(248, 20);
            this.textBoxUser.TabIndex = 13;
            this.textBoxUser.TextChanged += new System.EventHandler(this.updateDSN);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(99, 127);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(248, 20);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.updateDSN);
            // 
            // textBoxOptions
            // 
            this.textBoxOptions.Location = new System.Drawing.Point(99, 165);
            this.textBoxOptions.Name = "textBoxOptions";
            this.textBoxOptions.Size = new System.Drawing.Size(248, 20);
            this.textBoxOptions.TabIndex = 15;
            this.textBoxOptions.TextChanged += new System.EventHandler(this.updateDSN);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SQL Execution Response Type Checker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxOptions;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxTestConnectionResult;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.TextBox textBoxSQL;
    }
}

