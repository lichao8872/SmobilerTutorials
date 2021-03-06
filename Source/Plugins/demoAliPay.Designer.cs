﻿using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoAliPay : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.btnCreateOrder = new Smobiler.Core.Controls.Button();
            this.btnOrderStatus = new Smobiler.Core.Controls.Button();
            this.btnOutOrder = new Smobiler.Core.Controls.Button();
            this.labOutOrder = new Smobiler.Core.Controls.Label();
            this.aliPay1 = new Smobiler.Plugins.AliPay();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "AliPay";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(24, 134);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(100, 30);
            this.btnCreateOrder.Text = "创建订单";
            this.btnCreateOrder.Press += new System.EventHandler(this.btnCreateOrder_Press);
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Location = new System.Drawing.Point(142, 134);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(100, 30);
            this.btnOrderStatus.Text = "支付状态查询";
            this.btnOrderStatus.Press += new System.EventHandler(this.btnOrderStatus_Press);
            // 
            // btnOutOrder
            // 
            this.btnOutOrder.BorderRadius = 0;
            this.btnOutOrder.Location = new System.Drawing.Point(0, 66);
            this.btnOutOrder.Name = "btnOutOrder";
            this.btnOutOrder.Size = new System.Drawing.Size(100, 35);
            this.btnOutOrder.Text = "生成订单编号";
            this.btnOutOrder.Press += new System.EventHandler(this.btnOutOrder_Press);
            // 
            // labOutOrder
            // 
            this.labOutOrder.Location = new System.Drawing.Point(100, 66);
            this.labOutOrder.Name = "labOutOrder";
            this.labOutOrder.Size = new System.Drawing.Size(200, 35);
            this.labOutOrder.Text = "[外部订单]";
            // 
            // aliPay1
            // 
            this.aliPay1.Name = "aliPay1";
            // 
            // demoAliPay
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.aliPay1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnCreateOrder,
            this.btnOrderStatus,
            this.btnOutOrder,
            this.labOutOrder});
            this.Name = "demoAliPay";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnCreateOrder;
        private Core.Controls.Button btnOrderStatus;
        private Core.Controls.Button btnOutOrder;
        private Core.Controls.Label labOutOrder;
        private Smobiler.Plugins.AliPay aliPay1;
    }
}