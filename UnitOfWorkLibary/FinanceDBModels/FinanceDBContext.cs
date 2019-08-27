using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class FinanceDBContext : DbContext
    {
        public FinanceDBContext()
        {
        }

        public FinanceDBContext(DbContextOptions<FinanceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerAddressRepl> CustomerAddressRepl { get; set; }
        public virtual DbSet<CustomerRepl> CustomerRepl { get; set; }
        public virtual DbSet<CustomerVatinfoRepl> CustomerVatinfoRepl { get; set; }
        public virtual DbSet<DoItemRepl> DoItemRepl { get; set; }
        public virtual DbSet<DoMasterRepl> DoMasterRepl { get; set; }
        public virtual DbSet<EnterpriseTypeRepl> EnterpriseTypeRepl { get; set; }
        public virtual DbSet<SoItemRepl> SoItemRepl { get; set; }
        public virtual DbSet<SoMasterRepl> SoMasterRepl { get; set; }
        public virtual DbSet<SysUserOutRepl> SysUserOutRepl { get; set; }
        public virtual DbSet<SysUserRepl> SysUserRepl { get; set; }
        public virtual DbSet<TabnormalDataMonitor> TabnormalDataMonitor { get; set; }
        public virtual DbSet<TacceptancePayment> TacceptancePayment { get; set; }
        public virtual DbSet<TacceptancePaymentHandle> TacceptancePaymentHandle { get; set; }
        public virtual DbSet<TacceptancePaymentItem> TacceptancePaymentItem { get; set; }
        public virtual DbSet<TaccessPartyAccount> TaccessPartyAccount { get; set; }
        public virtual DbSet<TaccountsPayable> TaccountsPayable { get; set; }
        public virtual DbSet<TadvancePayment> TadvancePayment { get; set; }
        public virtual DbSet<TadvancePaymentHandle> TadvancePaymentHandle { get; set; }
        public virtual DbSet<TadvancePaymentItem> TadvancePaymentItem { get; set; }
        public virtual DbSet<TadvancePaymentMap> TadvancePaymentMap { get; set; }
        public virtual DbSet<Tagency> Tagency { get; set; }
        public virtual DbSet<TagencyAgent> TagencyAgent { get; set; }
        public virtual DbSet<TagencyNode> TagencyNode { get; set; }
        public virtual DbSet<TapplicationUpgrade> TapplicationUpgrade { get; set; }
        public virtual DbSet<TapplicationVersion> TapplicationVersion { get; set; }
        public virtual DbSet<TautoExecuteSql> TautoExecuteSql { get; set; }
        public virtual DbSet<TautoExecuteSqlResult> TautoExecuteSqlResult { get; set; }
        public virtual DbSet<TautoReportExport> TautoReportExport { get; set; }
        public virtual DbSet<TautoReportExportFile> TautoReportExportFile { get; set; }
        public virtual DbSet<TautoReportExportSubscription> TautoReportExportSubscription { get; set; }
        public virtual DbSet<TautoReportExportTime> TautoReportExportTime { get; set; }
        public virtual DbSet<TautoTask> TautoTask { get; set; }
        public virtual DbSet<TautoTaskClass> TautoTaskClass { get; set; }
        public virtual DbSet<TautoTaskLog> TautoTaskLog { get; set; }
        public virtual DbSet<TautoTaskServer> TautoTaskServer { get; set; }
        public virtual DbSet<TbatchToDoList> TbatchToDoList { get; set; }
        public virtual DbSet<TbusinessLogCompensatory> TbusinessLogCompensatory { get; set; }
        public virtual DbSet<TdataPublisher> TdataPublisher { get; set; }
        public virtual DbSet<TdataPublisherParameter> TdataPublisherParameter { get; set; }
        public virtual DbSet<TdataSubscription> TdataSubscription { get; set; }
        public virtual DbSet<TdataTrack> TdataTrack { get; set; }
        public virtual DbSet<Tdepartment> Tdepartment { get; set; }
        public virtual DbSet<Tdescription> Tdescription { get; set; }
        public virtual DbSet<TdescriptionType> TdescriptionType { get; set; }
        public virtual DbSet<TdynamicSql> TdynamicSql { get; set; }
        public virtual DbSet<TelecInvoiceExtend> TelecInvoiceExtend { get; set; }
        public virtual DbSet<TfileUpload> TfileUpload { get; set; }
        public virtual DbSet<Tfund> Tfund { get; set; }
        public virtual DbSet<TfundTransfer> TfundTransfer { get; set; }
        public virtual DbSet<TfundTransferHis> TfundTransferHis { get; set; }
        public virtual DbSet<Thandle> Thandle { get; set; }
        public virtual DbSet<ThandleType> ThandleType { get; set; }
        public virtual DbSet<Tinvoice> Tinvoice { get; set; }
        public virtual DbSet<TinvoiceBusinessType> TinvoiceBusinessType { get; set; }
        public virtual DbSet<TinvoiceFund> TinvoiceFund { get; set; }
        public virtual DbSet<TinvoiceGroup> TinvoiceGroup { get; set; }
        public virtual DbSet<TinvoiceGroupDetail> TinvoiceGroupDetail { get; set; }
        public virtual DbSet<TinvoiceGroupOffice> TinvoiceGroupOffice { get; set; }
        public virtual DbSet<TinvoiceGroupProduct> TinvoiceGroupProduct { get; set; }
        public virtual DbSet<TinvoiceGroupReceiver> TinvoiceGroupReceiver { get; set; }
        public virtual DbSet<TinvoiceGroupVersion> TinvoiceGroupVersion { get; set; }
        public virtual DbSet<TinvoiceGroupVersionDetail> TinvoiceGroupVersionDetail { get; set; }
        public virtual DbSet<TinvoiceGroupVersionReceiver> TinvoiceGroupVersionReceiver { get; set; }
        public virtual DbSet<TinvoiceHandle> TinvoiceHandle { get; set; }
        public virtual DbSet<TinvoiceItem> TinvoiceItem { get; set; }
        public virtual DbSet<TinvoiceItemHistory> TinvoiceItemHistory { get; set; }
        public virtual DbSet<TinvoiceOfCustomer> TinvoiceOfCustomer { get; set; }
        public virtual DbSet<TinvoiceOfVendor> TinvoiceOfVendor { get; set; }
        public virtual DbSet<TinvoiceResultImport> TinvoiceResultImport { get; set; }
        public virtual DbSet<TinvoiceVoucher> TinvoiceVoucher { get; set; }
        public virtual DbSet<Tlanguage> Tlanguage { get; set; }
        public virtual DbSet<TlongText> TlongText { get; set; }
        public virtual DbSet<TmailAttachment> TmailAttachment { get; set; }
        public virtual DbSet<TmailFailed> TmailFailed { get; set; }
        public virtual DbSet<TmailFormat> TmailFormat { get; set; }
        public virtual DbSet<TmailFormatAttachment> TmailFormatAttachment { get; set; }
        public virtual DbSet<TmailSent> TmailSent { get; set; }
        public virtual DbSet<TmailToSend> TmailToSend { get; set; }
        public virtual DbSet<Tnode> Tnode { get; set; }
        public virtual DbSet<TnodeActor> TnodeActor { get; set; }
        public virtual DbSet<TnodeApplication> TnodeApplication { get; set; }
        public virtual DbSet<TnodeCondition> TnodeCondition { get; set; }
        public virtual DbSet<TnodeInstance> TnodeInstance { get; set; }
        public virtual DbSet<TnodeInstanceActor> TnodeInstanceActor { get; set; }
        public virtual DbSet<TnodeInstanceHandle> TnodeInstanceHandle { get; set; }
        public virtual DbSet<TnodeLink> TnodeLink { get; set; }
        public virtual DbSet<TnodeLinkInstance> TnodeLinkInstance { get; set; }
        public virtual DbSet<TnodeProcess> TnodeProcess { get; set; }
        public virtual DbSet<TnodeSchedule> TnodeSchedule { get; set; }
        public virtual DbSet<TnoticeEvent> TnoticeEvent { get; set; }
        public virtual DbSet<TnoticeEventArgument> TnoticeEventArgument { get; set; }
        public virtual DbSet<TnoticeEventDataItem> TnoticeEventDataItem { get; set; }
        public virtual DbSet<TnoticeEventMessage> TnoticeEventMessage { get; set; }
        public virtual DbSet<TnoticeEventSubscription> TnoticeEventSubscription { get; set; }
        public virtual DbSet<TobjectPower> TobjectPower { get; set; }
        public virtual DbSet<Toccupation> Toccupation { get; set; }
        public virtual DbSet<TparameterSet> TparameterSet { get; set; }
        public virtual DbSet<TparameterSetDetail> TparameterSetDetail { get; set; }
        public virtual DbSet<TpartialReInvoice> TpartialReInvoice { get; set; }
        public virtual DbSet<TpayAccount> TpayAccount { get; set; }
        public virtual DbSet<TpaymentDetail> TpaymentDetail { get; set; }
        public virtual DbSet<TpaymentHeader> TpaymentHeader { get; set; }
        public virtual DbSet<Tposition> Tposition { get; set; }
        public virtual DbSet<TpositionLevel> TpositionLevel { get; set; }
        public virtual DbSet<Tpower> Tpower { get; set; }
        public virtual DbSet<Tprocess> Tprocess { get; set; }
        public virtual DbSet<TprocessInstance> TprocessInstance { get; set; }
        public virtual DbSet<TprocessParameter> TprocessParameter { get; set; }
        public virtual DbSet<TprocessSchedule> TprocessSchedule { get; set; }
        public virtual DbSet<TprocessVersion> TprocessVersion { get; set; }
        public virtual DbSet<TpublishedMessage> TpublishedMessage { get; set; }
        public virtual DbSet<TrebateMap> TrebateMap { get; set; }
        public virtual DbSet<TreceiverAccount> TreceiverAccount { get; set; }
        public virtual DbSet<Treconciliation> Treconciliation { get; set; }
        public virtual DbSet<TreconciliationDetail> TreconciliationDetail { get; set; }
        public virtual DbSet<TreconciliationExpand> TreconciliationExpand { get; set; }
        public virtual DbSet<TreconciliationProduct> TreconciliationProduct { get; set; }
        public virtual DbSet<TrecordChange> TrecordChange { get; set; }
        public virtual DbSet<TrecordChangeField> TrecordChangeField { get; set; }
        public virtual DbSet<TrefundBill> TrefundBill { get; set; }
        public virtual DbSet<TreplicationApplication> TreplicationApplication { get; set; }
        public virtual DbSet<TreplicationType> TreplicationType { get; set; }
        public virtual DbSet<Tschedule> Tschedule { get; set; }
        public virtual DbSet<TshortText> TshortText { get; set; }
        public virtual DbSet<TsiteReplication> TsiteReplication { get; set; }
        public virtual DbSet<TsmsFailed> TsmsFailed { get; set; }
        public virtual DbSet<TsmsFormat> TsmsFormat { get; set; }
        public virtual DbSet<TsmsReceivedPending> TsmsReceivedPending { get; set; }
        public virtual DbSet<TsmsSent> TsmsSent { get; set; }
        public virtual DbSet<TsmsToSend> TsmsToSend { get; set; }
        public virtual DbSet<TsmsToSendTimer> TsmsToSendTimer { get; set; }
        public virtual DbSet<TsysColsList> TsysColsList { get; set; }
        public virtual DbSet<TsysConfig> TsysConfig { get; set; }
        public virtual DbSet<TsysConfigClass> TsysConfigClass { get; set; }
        public virtual DbSet<TsysMaxNumber> TsysMaxNumber { get; set; }
        public virtual DbSet<TsysStatus> TsysStatus { get; set; }
        public virtual DbSet<TsysStatusLanguage> TsysStatusLanguage { get; set; }
        public virtual DbSet<TsysTablesList> TsysTablesList { get; set; }
        public virtual DbSet<TtaskType> TtaskType { get; set; }
        public virtual DbSet<TtimeLimit> TtimeLimit { get; set; }
        public virtual DbSet<TtoDoList> TtoDoList { get; set; }
        public virtual DbSet<TtoDoListErrorLog> TtoDoListErrorLog { get; set; }
        public virtual DbSet<TtoDoListHistory> TtoDoListHistory { get; set; }
        public virtual DbSet<TtoDoType> TtoDoType { get; set; }
        public virtual DbSet<Tuser> Tuser { get; set; }
        public virtual DbSet<TuserIp> TuserIp { get; set; }
        public virtual DbSet<TuserLogin> TuserLogin { get; set; }
        public virtual DbSet<TuserPasswordHistory> TuserPasswordHistory { get; set; }
        public virtual DbSet<TuserPosition> TuserPosition { get; set; }
        public virtual DbSet<TuserProfile> TuserProfile { get; set; }
        public virtual DbSet<TuserRelation> TuserRelation { get; set; }
        public virtual DbSet<TverificationFund> TverificationFund { get; set; }
        public virtual DbSet<TverificationGroup> TverificationGroup { get; set; }
        public virtual DbSet<TverificationGroupDetail> TverificationGroupDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=10.10.4.202;User ID=Test;Password=Test123456;database=FinanceDB;Min Pool Size=10;Max Pool Size=500;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CustomerAddressRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Customer_Address");

                entity.ToTable("Customer_Address_REPL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Brief).HasMaxLength(50);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.DistributionCode).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CUSTOMER");

                entity.ToTable("Customer_REPL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName).HasMaxLength(100);

                entity.Property(e => e.AccountNo).HasMaxLength(100);

                entity.Property(e => e.AccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.AddTaxTel).HasMaxLength(100);

                entity.Property(e => e.AddtaxNo).HasMaxLength(100);

                entity.Property(e => e.Aptype).HasColumnName("APType");

                entity.Property(e => e.Bank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BufferAccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BuyTime).HasColumnType("datetime");

                entity.Property(e => e.CardNo).HasMaxLength(50);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.CmuserSysNo).HasColumnName("CMUserSysNo");

                entity.Property(e => e.CompanyCode).HasMaxLength(200);

                entity.Property(e => e.CompanyLogo).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.CompanyScale).HasMaxLength(100);

                entity.Property(e => e.Contact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEnd).HasColumnType("datetime");

                entity.Property(e => e.ContractStart).HasColumnType("datetime");

                entity.Property(e => e.CorpContactContractName).HasMaxLength(100);

                entity.Property(e => e.CorpContactEmial).HasMaxLength(100);

                entity.Property(e => e.CorpContactMobliePhone).HasMaxLength(100);

                entity.Property(e => e.CorpContactTelePhone).HasMaxLength(100);

                entity.Property(e => e.CreditLine).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CurrentAccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CustomerGroup).HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerLabel).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DeliveryRequirements).HasMaxLength(100);

                entity.Property(e => e.District).HasMaxLength(25);

                entity.Property(e => e.DwellAddress).HasMaxLength(200);

                entity.Property(e => e.DwellZip).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpNumber).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FreightDemand).HasMaxLength(100);

                entity.Property(e => e.Industry).HasMaxLength(100);

                entity.Property(e => e.InvalidReason).HasMaxLength(500);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.InvoiceAndBillingRequirement).HasMaxLength(500);

                entity.Property(e => e.InvoiceArrivedTime).HasMaxLength(100);

                entity.Property(e => e.IsprintPrice).HasColumnName("ISPrintPrice");

                entity.Property(e => e.LastLoginIp)
                    .HasColumnName("LastLoginIP")
                    .HasMaxLength(50);

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LastTypeChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LegalRepresentative).HasMaxLength(50);

                entity.Property(e => e.MinimumRequirements).HasMaxLength(100);

                entity.Property(e => e.Msn).HasMaxLength(100);

                entity.Property(e => e.Nickname).HasMaxLength(60);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(50);

                entity.Property(e => e.ReceiveContact).HasMaxLength(50);

                entity.Property(e => e.ReceiveFax).HasMaxLength(50);

                entity.Property(e => e.ReceiveName).HasMaxLength(50);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivePhone).HasMaxLength(50);

                entity.Property(e => e.ReceiveZip).HasMaxLength(50);

                entity.Property(e => e.RegisterTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnRequest).HasMaxLength(100);

                entity.Property(e => e.SourceDesc).HasMaxLength(30);

                entity.Property(e => e.SumCreditLine).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.TotalFreeShipFee).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.TransitionDatetime).HasColumnType("datetime");

                entity.Property(e => e.UnitCode).HasMaxLength(50);

                entity.Property(e => e.ValidFreeShipFee).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Viprank).HasColumnName("VIPRank");
            });

            modelBuilder.Entity<CustomerVatinfoRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Customer_VATInfo");

                entity.ToTable("Customer_VATInfo_REPL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.BankInfo).HasMaxLength(100);

                entity.Property(e => e.CompanyAddress).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerDepartmentId).HasColumnName("CustomerDepartmentID");

                entity.Property(e => e.Image1).HasMaxLength(100);

                entity.Property(e => e.Image2).HasMaxLength(100);

                entity.Property(e => e.Image3).HasMaxLength(100);

                entity.Property(e => e.Image4).HasMaxLength(100);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.TaxNum).HasMaxLength(20);
            });

            modelBuilder.Entity<DoItemRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_Item");

                entity.ToTable("DO_Item_REPL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BalancePay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.DosysNo).HasColumnName("DOSysNo");

                entity.Property(e => e.GiftCardPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.ProductNote).HasMaxLength(4000);

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.Volume).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<DoMasterRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_MASTER");

                entity.ToTable("DO_Master_REPL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.AggregateAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CheckQtyTime).HasColumnType("datetime");

                entity.Property(e => e.Codamt)
                    .HasColumnName("CODAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DistributionCode).HasMaxLength(200);

                entity.Property(e => e.DlsysNo).HasColumnName("DLSysNo");

                entity.Property(e => e.Doid)
                    .IsRequired()
                    .HasColumnName("DOID")
                    .HasMaxLength(20);

                entity.Property(e => e.EndAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Exportlist)
                    .HasColumnName("EXPORTLIST")
                    .HasMaxLength(2000);

                entity.Property(e => e.Express).HasMaxLength(50);

                entity.Property(e => e.ExpressNo).HasMaxLength(50);

                entity.Property(e => e.ExpressWeight).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.IsHaveInvoice).HasColumnName("isHaveInvoice");

                entity.Property(e => e.IscancelOutStock).HasColumnName("ISCancelOutStock");

                entity.Property(e => e.IsprintPrice).HasColumnName("ISPrintPrice");

                entity.Property(e => e.LatestCollectionTime).HasColumnType("datetime");

                entity.Property(e => e.MergerDoid)
                    .HasColumnName("MergerDOID")
                    .HasMaxLength(20);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PickupPrintIp)
                    .HasColumnName("PickupPrintIP")
                    .HasMaxLength(50);

                entity.Property(e => e.PickupPrintTime).HasColumnType("datetime");

                entity.Property(e => e.PointShipPrice).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.PointsAmt).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.ProductInvoiceType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveContact).HasMaxLength(20);

                entity.Property(e => e.ReceiveName).HasMaxLength(40);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivePhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiveZip).HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.SetDeliveryManTime).HasColumnType("datetime");

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SignOperator).HasMaxLength(50);

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.SyncTime).HasColumnType("datetime");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");

                entity.Property(e => e.Wmsweight)
                    .HasColumnName("WMSWeight")
                    .HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<EnterpriseTypeRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Enterpri__EB33D9B11A37412B");

                entity.ToTable("EnterpriseType_REPL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SoItemRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_ITEM")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SO_Item_REPL");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("IX_SO_Item")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.CdsysNo).HasColumnName("CDSysNo");

                entity.Property(e => e.ContractDescription).HasMaxLength(200);

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponAmtApportion).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponAmtApportionForPm)
                    .HasColumnName("CouponAmtApportionForPM")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Isinstall).HasColumnName("ISInstall");

                entity.Property(e => e.IsvirtualStock).HasColumnName("ISVirtualStock");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ProductNote).HasMaxLength(4000);

                entity.Property(e => e.RealPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.Volume).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<SoMasterRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_MASTER");

                entity.ToTable("SO_Master_REPL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.AuditDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BalancePayAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BdenterpriseTypeSysNo).HasColumnName("BDEnterpriseTypeSysNo");

                entity.Property(e => e.BdsaleManSysNo).HasColumnName("BDSaleManSysNo");

                entity.Property(e => e.CashPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ChannelSoid)
                    .HasColumnName("ChannelSOID")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckQtyTime).HasColumnType("datetime");

                entity.Property(e => e.CloseMsg).HasMaxLength(255);

                entity.Property(e => e.CmuserSysNo).HasColumnName("CMUserSysNo");

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponCode).HasMaxLength(50);

                entity.Property(e => e.CouponReturnRosysNo).HasColumnName("CouponReturnROSysNo");

                entity.Property(e => e.CsuserSysNo).HasColumnName("CSUserSysNo");

                entity.Property(e => e.CustomerOnLockTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerVatInfoId).HasColumnName("CustomerVatInfoID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMemo).HasMaxLength(200);

                entity.Property(e => e.DepartmentCompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DistributionCode).HasMaxLength(200);

                entity.Property(e => e.DlsysNo).HasColumnName("DLSysNo");

                entity.Property(e => e.ExpectAuditDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Exportlist)
                    .HasColumnName("EXPORTLIST")
                    .HasMaxLength(2000);

                entity.Property(e => e.FreeShipFeePay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.GiftCardPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.HoldTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNote).HasMaxLength(500);

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.IsMergeSo).HasColumnName("IsMergeSO");

                entity.Property(e => e.IsVat).HasColumnName("IsVAT");

                entity.Property(e => e.IsreceiveSms).HasColumnName("ISReceiveSMS");

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.ManagerAuditTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Omssoid)
                    .HasColumnName("OMSSOID")
                    .HasMaxLength(50);

                entity.Property(e => e.OperatorAddressId).HasColumnName("OperatorAddressID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PayPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PosFee).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.PremiumAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductInvoiceType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RealSoamt)
                    .HasColumnName("RealSOAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveContact).HasMaxLength(20);

                entity.Property(e => e.ReceiveEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiveName).HasMaxLength(40);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivePhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveZip).HasMaxLength(20);

                entity.Property(e => e.RequestInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnCoupons).HasMaxLength(2000);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.SetDeliveryManTime).HasColumnType("datetime");

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShipPriceDosysNo).HasColumnName("ShipPriceDOSysNo");

                entity.Property(e => e.Soamt)
                    .HasColumnName("SOAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Soid)
                    .IsRequired()
                    .HasColumnName("SOID")
                    .HasMaxLength(20);

                entity.Property(e => e.Sosource).HasColumnName("SOSource");

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasMaxLength(100);

                entity.Property(e => e.TaoBaoAliPayOrder).HasMaxLength(20);

                entity.Property(e => e.TaoBaoOrderId)
                    .HasColumnName("TaoBaoOrderID")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseCoupons).HasMaxLength(2000);

                entity.Property(e => e.Vatemsfee)
                    .HasColumnName("VATEMSFee")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SysUserOutRepl>(entity =>
            {
                entity.HasKey(e => e.Sysno)
                    .HasName("PK_Sys_User_Out");

                entity.ToTable("Sys_User_Out_REPL");

                entity.Property(e => e.Sysno).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Phone).HasMaxLength(100);
            });

            modelBuilder.Entity<SysUserRepl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_USER");

                entity.ToTable("Sys_User_REPL");

                entity.HasIndex(e => e.BossSysNo)
                    .HasName("Ncl_Index_BossSysNo");

                entity.HasIndex(e => e.BranchSysNo)
                    .HasName("Ncl_Index_BranchSysNo");

                entity.HasIndex(e => e.DepartmentSysNo)
                    .HasName("Ncl_Index_DepartmentSysNo");

                entity.HasIndex(e => e.PmgroupSysNo)
                    .HasName("Ncl_Index_PMGroupSysNo");

                entity.HasIndex(e => e.StationSysNo)
                    .HasName("Ncl_Index_StationSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HmcustomerType)
                    .HasColumnName("HMCustomerType")
                    .HasMaxLength(20);

                entity.Property(e => e.Isfreeze)
                    .IsRequired()
                    .HasColumnName("isfreeze")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangePwdTime).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.PmgroupSysNo).HasColumnName("PMGroupSysNo");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tsrgroup).HasColumnName("TSRGroup");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TabnormalDataMonitor>(entity =>
            {
                entity.HasKey(e => e.MonitorId)
                    .HasName("PK_TABNORMALDATAMONITOR");

                entity.ToTable("TAbnormalDataMonitor");

                entity.Property(e => e.MonitorId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.MonitorName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.SqlStatement)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TacceptancePayment>(entity =>
            {
                entity.HasKey(e => e.AcceptancePaymentId);

                entity.ToTable("TAcceptancePayment");

                entity.HasIndex(e => e.VendorId)
                    .HasName("Index_VendorId");

                entity.Property(e => e.AcceptancePaymentId).ValueGeneratedNever();

                entity.Property(e => e.AdvancePaymentAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EstimatePayTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(600);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PaidInAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PaidTime).HasColumnType("datetime");

                entity.Property(e => e.PayAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PayMethod).HasMaxLength(1);

                entity.Property(e => e.RebateAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VoucherNo)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TacceptancePaymentHandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_TACCEPTANCEPAYMENTHANDLE");

                entity.ToTable("TAcceptancePaymentHandle");

                entity.HasIndex(e => e.AcceptancePaymentId)
                    .HasName("Index_AcceptancePaymentId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TacceptancePaymentItem>(entity =>
            {
                entity.HasKey(e => e.AcceptancePaymentItemId)
                    .HasName("PK_Finance_AP_Item");

                entity.ToTable("TAcceptancePaymentItem");

                entity.HasIndex(e => e.AcceptancePaymentId)
                    .HasName("Index_AcceptancePaymentId");

                entity.HasIndex(e => e.AccountsPayableId)
                    .HasName("Index_AccountsPayableId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PopayAmt)
                    .HasColumnName("POPayAmt")
                    .HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<TaccessPartyAccount>(entity =>
            {
                entity.HasKey(e => e.AccessPartyId)
                    .HasName("PK_TACCESSPARTYACCOUNT");

                entity.ToTable("TAccessPartyAccount");

                entity.Property(e => e.AccessPartyAccountNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccessPartyCallUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AccessPartyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AccessPartyRemark)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AccessPartySecret)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Standby1)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Standby2)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaccountsPayable>(entity =>
            {
                entity.HasKey(e => e.AccountsPayableId)
                    .HasName("PK_AccountsPayable");

                entity.ToTable("TAccountsPayable");

                entity.HasIndex(e => e.PoCode)
                    .HasName("Index_PoCode");

                entity.HasIndex(e => e.PoId)
                    .HasName("Index_PoID");

                entity.HasIndex(e => e.ReferCode)
                    .HasName("Index_ReferCode");

                entity.HasIndex(e => e.VendorId)
                    .HasName("Index_VendorId");

                entity.Property(e => e.AccountsPayableId).ValueGeneratedNever();

                entity.Property(e => e.AlreadyPayAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.AsnDoCreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InTimeOrOutTime).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.PoCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PoCreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReferCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReferType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TadvancePayment>(entity =>
            {
                entity.HasKey(e => e.AdvancePaymentId)
                    .HasName("PK_TADVANCEPAYMENT");

                entity.ToTable("TAdvancePayment");

                entity.HasIndex(e => e.ReferId)
                    .HasName("Index_ReferID");

                entity.HasIndex(e => e.VendorId)
                    .HasName("Index_VendorId");

                entity.Property(e => e.AdvancePaymentId).ValueGeneratedNever();

                entity.Property(e => e.AdvanceAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PaidTime).HasColumnType("datetime");

                entity.Property(e => e.ReferId).HasColumnName("ReferID");

                entity.Property(e => e.ReferType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VerifyAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.VerifyStatus)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TadvancePaymentHandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_TADVANCEPAYMENTHANDLE");

                entity.ToTable("TAdvancePaymentHandle");

                entity.HasIndex(e => e.AdvancePaymentId)
                    .HasName("Index_AdvancePaymentId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TadvancePaymentItem>(entity =>
            {
                entity.HasKey(e => e.AdvancePaymentItemId);

                entity.ToTable("TAdvancePaymentItem");

                entity.HasIndex(e => e.AdvancePaymentId)
                    .HasName("Index_AdvancePaymentId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TadvancePaymentMap>(entity =>
            {
                entity.HasKey(e => e.AdvancePaymentMapId)
                    .HasName("PK_TADVANCEPAYMENTMAP");

                entity.ToTable("TAdvancePaymentMap");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tagency>(entity =>
            {
                entity.HasKey(e => e.AgencyId)
                    .HasName("PK_TAGENCY");

                entity.ToTable("TAgency");

                entity.Property(e => e.ActualEndTime).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsAllowSubAuthorize)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultiLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TagencyAgent>(entity =>
            {
                entity.HasKey(e => new { e.AgencyId, e.AgentUserId })
                    .HasName("PK_TAGENCYAGENT");

                entity.ToTable("TAgencyAgent");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TagencyNode>(entity =>
            {
                entity.HasKey(e => new { e.AgencyId, e.NodeId })
                    .HasName("PK_TAGENCYNODE");

                entity.ToTable("TAgencyNode");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TapplicationUpgrade>(entity =>
            {
                entity.HasKey(e => e.UpgradeId)
                    .HasName("PK_TAPPLICATIONUPGRADE");

                entity.ToTable("TApplicationUpgrade");

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ApplicationVersion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TapplicationVersion>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_TAPPLICATIONVERSION");

                entity.ToTable("TApplicationVersion");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CurrentVersion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoExecuteSql>(entity =>
            {
                entity.HasKey(e => e.SqlId)
                    .HasName("PK_TAUTOEXECUTESQL");

                entity.ToTable("TAutoExecuteSql");

                entity.Property(e => e.SqlId)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ExecuteDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.HasReturnData)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlStatement).HasColumnType("text");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoExecuteSqlResult>(entity =>
            {
                entity.HasKey(e => e.ExecuteId)
                    .HasName("PK_TAUTOEXECUTESQLRESULT");

                entity.ToTable("TAutoExecuteSqlResult");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsSuccess)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SqlId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TautoReportExport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_TAUTOREPORTEXPORT");

                entity.ToTable("TAutoReportExport");

                entity.Property(e => e.ReportId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecuteDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.FileFormat)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsSendMail)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ReportCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlStatement)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoReportExportFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_TAUTOREPORTEXPORTFILE");

                entity.ToTable("TAutoReportExportFile");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileFormat)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TautoReportExportSubscription>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.Email })
                    .HasName("PK_TAUTOREPORTEXPORTSUBSCRIPTI");

                entity.ToTable("TAutoReportExportSubscription");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoReportExportTime>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.ExecuteTime })
                    .HasName("PK_TAUTOREPORTEXPORTTIME");

                entity.ToTable("TAutoReportExportTime");

                entity.Property(e => e.ExecuteTime).HasMaxLength(8);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_TAUTOTASK");

                entity.ToTable("TAutoTask");

                entity.Property(e => e.TaskId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InitialValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsAutoExecute)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsEnableAlert)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ServerId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoTaskClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_TAUTOTASKCLASS");

                entity.ToTable("TAutoTaskClass");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoTaskLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_TAUTOTASKLOG");

                entity.ToTable("TAutoTaskLog");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LogContent)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ServerId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TaskId)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TautoTaskServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PK_TAUTOTASKSERVER");

                entity.ToTable("TAutoTaskServer");

                entity.Property(e => e.ServerId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbatchToDoList>(entity =>
            {
                entity.HasKey(e => e.ToDoListId)
                    .HasName("PK_TBATCHTODOLIST");

                entity.ToTable("TBatchToDoList");

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ToDoType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TbusinessLogCompensatory>(entity =>
            {
                entity.ToTable("TBusinessLogCompensatory");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdataPublisher>(entity =>
            {
                entity.HasKey(e => e.DataPublisherId)
                    .HasName("PK_TDATAPUBLISHER");

                entity.ToTable("TDataPublisher");

                entity.Property(e => e.DataPublisherId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataPublisherName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DataSourceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.SqlStatement).HasColumnType("text");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdataPublisherParameter>(entity =>
            {
                entity.HasKey(e => e.DataPublisherId)
                    .HasName("PK_TDATAPUBLISHERPARAMETER");

                entity.ToTable("TDataPublisherParameter");

                entity.Property(e => e.DataPublisherId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaxValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MinValue)
                    .IsRequired()
                    .HasColumnName("MInValue")
                    .HasMaxLength(255);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdataSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_TDATASUBSCRIPTION");

                entity.ToTable("TDataSubscription");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataPublisherId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SubscriptionType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TdataTrack>(entity =>
            {
                entity.HasKey(e => e.TrackId)
                    .HasName("PK_TDATATRACK");

                entity.ToTable("TDataTrack");

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TrackType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Tdepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_TDEPARTMENT");

                entity.ToTable("TDepartment");

                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DepartmentType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsFunction)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdescription>(entity =>
            {
                entity.HasKey(e => e.DescriptionId)
                    .HasName("PK_TDESCRIPTION");

                entity.ToTable("TDescription");

                entity.Property(e => e.DescriptionId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DescriptionTypeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdescriptionType>(entity =>
            {
                entity.HasKey(e => e.DescriptionTypeId)
                    .HasName("PK_TDESCRIPTIONTYPE");

                entity.ToTable("TDescriptionType");

                entity.Property(e => e.DescriptionTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdynamicSql>(entity =>
            {
                entity.HasKey(e => e.SqlUsageCode)
                    .HasName("PK_TDYNAMICSQL");

                entity.ToTable("TDynamicSql");

                entity.Property(e => e.SqlUsageCode)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.SqlUsageName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlUsageType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Sqlstatement)
                    .IsRequired()
                    .HasColumnName("SQLStatement")
                    .HasColumnType("text");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TelecInvoiceExtend>(entity =>
            {
                entity.ToTable("TElecInvoiceExtend");

                entity.HasIndex(e => e.InvoiceGroupId)
                    .HasName("NClX_TElecInvoiceExtend_InvoiceGroupId");

                entity.Property(e => e.AckStatus).HasMaxLength(1);

                entity.Property(e => e.AckTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(350);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TfileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_TFILEUPLOAD");

                entity.ToTable("TFileUpload");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.RelativeId2)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Usage)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Tfund>(entity =>
            {
                entity.HasKey(e => e.FundId)
                    .HasName("PK_TFUND");

                entity.ToTable("TFund");

                entity.HasIndex(e => new { e.BranchId, e.ClaimType, e.InputFundTime })
                    .HasName("IX_TFund_BranchId");

                entity.Property(e => e.FundId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.BindingStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BoundAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerGroupName).HasMaxLength(200);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstVerificationTime).HasColumnType("datetime");

                entity.Property(e => e.FundRemark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FundType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IncomingAssigned).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.IncomingBank).HasMaxLength(100);

                entity.Property(e => e.IncomingSerialNo).HasMaxLength(200);

                entity.Property(e => e.IncomingUnassigned).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.InputFundTime).HasColumnType("datetime");

                entity.Property(e => e.RejectReason).HasMaxLength(500);

                entity.Property(e => e.RejectTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RemitCompany)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UnVerificationAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationStatus)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TfundTransfer>(entity =>
            {
                entity.HasKey(e => e.FundTransferId)
                    .HasName("PK_TFUNDTRANSFER");

                entity.ToTable("TFundTransfer");

                entity.Property(e => e.FundTransferId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InputFundTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UnVerificationAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationStatus)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TfundTransferHis>(entity =>
            {
                entity.HasKey(e => e.FundTransferHisId)
                    .HasName("PK_TFUNDTRANSFERHIS");

                entity.ToTable("TFundTransferHis");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerGroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperateType).HasMaxLength(1);

                entity.Property(e => e.TransferAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TransferSource)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Thandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_THANDLE");

                entity.ToTable("THandle");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<ThandleType>(entity =>
            {
                entity.HasKey(e => e.HandleTypeId)
                    .HasName("PK_THANDLETYPE");

                entity.ToTable("THandleType");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tinvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK_TINVOICE");

                entity.ToTable("TInvoice");

                entity.Property(e => e.InvoiceId).ValueGeneratedNever();

                entity.Property(e => e.AmountExcludeTax).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ApplyAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.AuditStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvocieContactName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InvoiceBankAccount)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceBankName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceBusinessType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.InvoicePhone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceShipAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InvoiceShipType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.InvoiceTaxNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.InvoicerContactPhone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShipFee).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UnVerifyAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerifyAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.VerifyStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TinvoiceBusinessType>(entity =>
            {
                entity.HasKey(e => e.InvoiceBusinessTypeId)
                    .HasName("PK_TINVOICEBUSINESSTYPE");

                entity.ToTable("TInvoiceBusinessType");

                entity.Property(e => e.InvoiceBusinessTypeId).ValueGeneratedNever();

                entity.Property(e => e.BusinessTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessTypeRemark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceFund>(entity =>
            {
                entity.HasKey(e => e.InvoiceFundId)
                    .HasName("PK_TINVOICEFUND");

                entity.ToTable("TInvoiceFund");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.InvoiceNo).IsRequired();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceGroup>(entity =>
            {
                entity.HasKey(e => e.InvoiceGroupId)
                    .HasName("PK_TINVOICEGROUP");

                entity.ToTable("TInvoiceGroup");

                entity.Property(e => e.InvoiceGroupId).ValueGeneratedNever();

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.AckStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AckTime).HasColumnType("datetime");

                entity.Property(e => e.AllowedDiffAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BindingStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CancelTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerFullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerInvoiceRemark).HasMaxLength(500);

                entity.Property(e => e.ErrorReason).HasMaxLength(500);

                entity.Property(e => e.ExportTime).HasColumnType("datetime");

                entity.Property(e => e.ExpressCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImportTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceAddress).HasMaxLength(200);

                entity.Property(e => e.InvoiceFlowNumber).HasMaxLength(200);

                entity.Property(e => e.InvoiceGroupSource)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.InvoicePhone).HasMaxLength(50);

                entity.Property(e => e.InvoiceReceiver)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.InvoiceRequest).HasMaxLength(500);

                entity.Property(e => e.InvoiceTaxNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsSplitMergeToInvoice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RealInvoiceAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.RedInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.SellerBankCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationStatus).HasMaxLength(1);

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceGroupDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK_TINVOICEGROUPDETAIL");

                entity.ToTable("TInvoiceGroupDetail");

                entity.HasIndex(e => e.InvoiceGroupId);

                entity.HasIndex(e => new { e.ReferCode, e.ReferType })
                    .HasName("IX_TInvoiceGroupDetail_ReferCode");

                entity.HasIndex(e => new { e.ReferId, e.ReferType, e.Status })
                    .HasName("idx_TInvoiceGroupDetail_ReferId_ReferType_Status");

                entity.HasIndex(e => new { e.DetailId, e.InvoiceGroupId, e.ReferId, e.ReferType, e.Status, e.CustomerCode, e.UpdateTime })
                    .HasName("IX_TInvoiceGroupDetail_UpdateTime");

                entity.Property(e => e.DetailId).ValueGeneratedNever();

                entity.Property(e => e.CostCenterName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DoCode).HasMaxLength(20);

                entity.Property(e => e.ReferAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReferCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReferType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SaleOrderCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceGroupOffice>(entity =>
            {
                entity.ToTable("TInvoiceGroupOffice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BranchName).HasMaxLength(100);

                entity.Property(e => e.CancelTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DoAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DoCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ElecEmail).HasMaxLength(50);

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SaleUserName).HasMaxLength(50);

                entity.Property(e => e.SoAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SoCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceGroupProduct>(entity =>
            {
                entity.HasKey(e => e.InvoiceGroupProductId)
                    .HasName("PK_TINVOICEGROUPPRODUCT");

                entity.ToTable("TInvoiceGroupProduct");

                entity.HasIndex(e => new { e.DetailId, e.ProductId, e.ProductCode, e.ProductMode, e.ProductName, e.ProductUnit, e.Price, e.TaxCodeCategory, e.TaxRate, e.Quantity, e.InvoiceGroupId })
                    .HasName("IX_TInvoiceGroupProduct_InvoiceGroupId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Modal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductMode).HasMaxLength(100);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.ProductUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCodeCategory).HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceGroupReceiver>(entity =>
            {
                entity.HasKey(e => e.InvoiceGroupReceiverId)
                    .HasName("PK_TINVOICEGROUPRECEIVER");

                entity.ToTable("TInvoiceGroupReceiver");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverMail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverMobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TinvoiceGroupVersion>(entity =>
            {
                entity.HasKey(e => e.InvoiceGroupVersionId)
                    .HasName("PK_TINVOICEGROUPVERSION");

                entity.ToTable("TInvoiceGroupVersion");

                entity.Property(e => e.InvoiceGroupVersionId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SpecialDiffAmountReason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TinvoiceGroupVersionDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceGroupVersionDetailId)
                    .HasName("PK_TINVOICEGROUPVERSIONDETAIL");

                entity.ToTable("TInvoiceGroupVersionDetail");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerInvoiceRemark)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.CustomerInvoiceType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceProductCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceProductMode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceProductName)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.InvoiceProductUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceRequest)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.InvoiceTax).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceUntaxedAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsNeedSecondaryConfirmation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OriginalProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SecondaryConfirmationReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UploadedFilePath)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TinvoiceGroupVersionReceiver>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceGroupVersionId, e.InvoiceSerialNo })
                    .HasName("PK_TINVOICEGROUPVERSIONRECEIVE");

                entity.ToTable("TInvoiceGroupVersionReceiver");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverMobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TinvoiceHandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_TINVOICEHANDLE");

                entity.ToTable("TInvoiceHandle");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TinvoiceItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceItemId)
                    .HasName("PK_TINVOICEITEM");

                entity.ToTable("TInvoiceItem");

                entity.Property(e => e.InvoiceItemId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceQuantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductSkuName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceItemHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_TINVOICEITEMHISTORY");

                entity.ToTable("TInvoiceItemHistory");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.InvoicePrice).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.InvoiceQuantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductSkuName)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<TinvoiceOfCustomer>(entity =>
            {
                entity.HasKey(e => e.InvoiceOcrid)
                    .HasName("PK_TINVOICEOFCUSTOMER");

                entity.ToTable("TInvoiceOfCustomer");

                entity.Property(e => e.InvoiceOcrid).HasColumnName("InvoiceOCRId");

                entity.Property(e => e.ChineseAmount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCrc)
                    .IsRequired()
                    .HasColumnName("InvoiceCRC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceFileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSaler)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceSalerAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceSalerAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceSalerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSeq)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceTax).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceVatAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TinvoiceOfVendor>(entity =>
            {
                entity.HasKey(e => e.InvoiceOcrid)
                    .HasName("PK_TINVOICEOFVENDOR");

                entity.ToTable("TInvoiceOfVendor");

                entity.Property(e => e.InvoiceOcrid).HasColumnName("InvoiceOCRId");

                entity.Property(e => e.ChineseAmount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCrc)
                    .IsRequired()
                    .HasColumnName("InvoiceCRC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceFileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSaler)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceSalerAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceSalerAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceSalerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSeq)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceTax).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceVatAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TinvoiceResultImport>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK_TINVOICERESULTIMPORT");

                entity.ToTable("TInvoiceResultImport");

                entity.HasIndex(e => e.InvoiceGroupId);

                entity.Property(e => e.ImportId).ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerTaxNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Drawer)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceTime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsAbandon)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ItemSpecification)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemUnit)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Payee)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Reviewer)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SalesAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SalesBankName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinvoiceVoucher>(entity =>
            {
                entity.HasKey(e => e.InvoiceVoucherId)
                    .HasName("PK_TINVOICEVOUCHER");

                entity.ToTable("TInvoiceVoucher");

                entity.Property(e => e.InvoiceVoucherId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceBusinessType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ShipFee).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tlanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK_TLANGUAGE");

                entity.ToTable("TLanguage");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlongText>(entity =>
            {
                entity.HasKey(e => e.LongTextId)
                    .HasName("PK_TLONGTEXT");

                entity.ToTable("TLongText");

                entity.Property(e => e.LongTextId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TextContent)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TmailAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_TMAILATTACHMENT");

                entity.ToTable("TMailAttachment");

                entity.Property(e => e.AttachmentId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailFailed>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK_TMAILFAILED")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TMailFailed");

                entity.Property(e => e.MailId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FailDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.LastRetryTime).HasColumnType("datetime");

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<TmailFormat>(entity =>
            {
                entity.HasKey(e => e.MailFormatId)
                    .HasName("PK_TMAILFORMAT");

                entity.ToTable("TMailFormat");

                entity.Property(e => e.MailFormatId).ValueGeneratedNever();

                entity.Property(e => e.ContentUrl)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAllowEdit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsEnablEdit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.MailBcc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailContent).HasColumnType("text");

                entity.Property(e => e.MailFormatCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.MailFormatName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerifyWord)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailFormatAttachment>(entity =>
            {
                entity.HasKey(e => e.AttatchmentId)
                    .HasName("PK_TMAILFORMATATTACHMENT");

                entity.ToTable("TMailFormatAttachment");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailSent>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK_TMAILSENT")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TMailSent");

                entity.Property(e => e.MailId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailToSend>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK_TMAILTOSEND");

                entity.ToTable("TMailToSend");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<Tnode>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODE");

                entity.ToTable("TNode");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsAutoAllocateActor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsAutoExecute)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsCancelWhenExpired)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultiActor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.NodeInstanceName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.NodeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeActor>(entity =>
            {
                entity.HasKey(e => e.NodeActorId)
                    .HasName("PK_TNODEACTOR");

                entity.ToTable("TNodeActor");

                entity.Property(e => e.NodeActorId).ValueGeneratedNever();

                entity.Property(e => e.ActType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActorRelationType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ActorRelationValue)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ActorSource)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActorType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsIncludeChild)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsIncludePlurality)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultiActor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeApplication>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODEAPPLICATION")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TNodeApplication");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ConfigValue1)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ConfigValue2)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeCondition>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODECONDITION")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TNodeCondition");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.CompleteCondition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DynamicCompileFile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndConditionDisplayNote)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.StartCondition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.StartConditionDisplayNote)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeInstance>(entity =>
            {
                entity.HasKey(e => e.NodeInstanceId)
                    .HasName("PK_TNODEINSTANCE");

                entity.ToTable("TNodeInstance");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EarliestDateExpired).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastDateExpired).HasColumnType("datetime");

                entity.Property(e => e.NodeInstanceName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StardandDateExpired).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TnodeInstanceActor>(entity =>
            {
                entity.HasKey(e => e.InstanceActorId)
                    .HasName("PK_TNODEINSTANCEACTOR");

                entity.ToTable("TNodeInstanceActor");

                entity.Property(e => e.ActType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActorType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeInstanceHandle>(entity =>
            {
                entity.HasKey(e => e.HandelId)
                    .HasName("PK_TNODEINSTANCEHANDLE");

                entity.ToTable("TNodeInstanceHandle");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PK_TNODELINK");

                entity.ToTable("TNodeLink");

                entity.Property(e => e.LinkId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DynamicCompileFile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsJumpByCondition)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.JumpCondition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.JumpConditionDisplayNote)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeLinkInstance>(entity =>
            {
                entity.HasKey(e => e.LinkInstanceId)
                    .HasName("PK_TNODELINKINSTANCE");

                entity.ToTable("TNodeLinkInstance");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeProcess>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODEPROCESS")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TNodeProcess");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeSchedule>(entity =>
            {
                entity.HasKey(e => new { e.NodeId, e.ScheduleId })
                    .HasName("PK_TNODESCHEDULE");

                entity.ToTable("TNodeSchedule");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TnoticeEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_TNOTICEEVENT");

                entity.ToTable("TNoticeEvent");

                entity.Property(e => e.EventId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsUse)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SendType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SubscriptionType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnoticeEventArgument>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.ArgumentName })
                    .HasName("PK_TNOTICEEVENTARGUMENT");

                entity.ToTable("TNoticeEventArgument");

                entity.Property(e => e.EventId).HasMaxLength(60);

                entity.Property(e => e.ArgumentName).HasMaxLength(60);

                entity.Property(e => e.ArgumentDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnoticeEventDataItem>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.DataItemName })
                    .HasName("PK_TNOTICEEVENTDATAITEM");

                entity.ToTable("TNoticeEventDataItem");

                entity.Property(e => e.EventId).HasMaxLength(60);

                entity.Property(e => e.DataItemName).HasMaxLength(60);

                entity.Property(e => e.DataItemDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TnoticeEventMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_TNOTICEEVENTMESSAGE");

                entity.ToTable("TNoticeEventMessage");

                entity.Property(e => e.MessageId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsUse)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.MessageFormatId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnoticeEventSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_TNOTICEEVENTSUBSCRIPTION");

                entity.ToTable("TNoticeEventSubscription");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Subscriber)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TobjectPower>(entity =>
            {
                entity.HasKey(e => new { e.ObjectType, e.ObjectId })
                    .HasName("PK_TOBJECTPOWER");

                entity.ToTable("TObjectPower");

                entity.Property(e => e.ObjectType).HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PowerValue)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Toccupation>(entity =>
            {
                entity.HasKey(e => e.OccupationId)
                    .HasName("PK_TOCCUPATION");

                entity.ToTable("TOccupation");

                entity.Property(e => e.OccupationId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OccupationCode)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationName).HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TparameterSet>(entity =>
            {
                entity.HasKey(e => e.SetId)
                    .HasName("PK_TPARAMETERSET");

                entity.ToTable("TParameterSet");

                entity.Property(e => e.SetId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TparameterSetDetail>(entity =>
            {
                entity.HasKey(e => new { e.SetId, e.ParameterName })
                    .HasName("PK_TPARAMETERSETDETAIL");

                entity.ToTable("TParameterSetDetail");

                entity.Property(e => e.ParameterName).HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ParameterValue)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TpartialReInvoice>(entity =>
            {
                entity.HasKey(e => e.PartialReInvoiceId)
                    .HasName("PK_TPARTIALREINVOICE");

                entity.ToTable("TPartialReInvoice");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ToRelatedInvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TpayAccount>(entity =>
            {
                entity.HasKey(e => e.PayAccountId)
                    .HasName("PK_TPAYACCOUNT");

                entity.ToTable("TPayAccount");

                entity.Property(e => e.BankAddress).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsHostToHost)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.OpenBank).HasMaxLength(200);

                entity.Property(e => e.PayAccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayAccountName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PayAccountRemark).HasMaxLength(2000);

                entity.Property(e => e.PayBankAccount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayCallBackUrl).HasMaxLength(200);

                entity.Property(e => e.PayHttpsPort)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayServiceUrl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaySignPort)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TpaymentDetail>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailId)
                    .HasName("PK_TPAYMENTDETAIL");

                entity.ToTable("TPaymentDetail");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.Property(e => e.PayAmount)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PayResultMsg).HasMaxLength(200);

                entity.Property(e => e.PayResultStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark).HasMaxLength(4000);

                entity.Property(e => e.RequestMessage).HasMaxLength(4000);

                entity.Property(e => e.ResponesMessage).HasMaxLength(4000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TpaymentHeader>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_TPAYMENTHEADER");

                entity.ToTable("TPaymentHeader");

                entity.Property(e => e.PaymentId).ValueGeneratedNever();

                entity.Property(e => e.ActualAmount)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DealWithWay)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DefrayAmount)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InternalRemark).HasMaxLength(500);

                entity.Property(e => e.PayAmount)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PayBankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayDeptName).HasMaxLength(50);

                entity.Property(e => e.PayMethod)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayRemark).HasMaxLength(500);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayUseCn)
                    .HasColumnName("PayUseCN")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptFlag).HasMaxLength(1);

                entity.Property(e => e.ReceiptId)
                    .HasColumnName("ReceiptID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiveBankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveBankAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceiveBankCity).HasMaxLength(50);

                entity.Property(e => e.ReceiveBankProvince).HasMaxLength(50);

                entity.Property(e => e.ReceiveEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveOpanBank).HasMaxLength(50);

                entity.Property(e => e.ReceiverAccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverAccountName).HasMaxLength(50);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCreateTime).HasColumnType("datetime");

                entity.Property(e => e.SourceSystem)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tposition>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("PK_TPOSITION");

                entity.ToTable("TPosition");

                entity.Property(e => e.PositionId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TpositionLevel>(entity =>
            {
                entity.HasKey(e => e.PositionLevelId)
                    .HasName("PK_TPOSITIONLEVEL");

                entity.ToTable("TPositionLevel");

                entity.Property(e => e.PositionLevelId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PositionLevelName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tpower>(entity =>
            {
                entity.HasKey(e => e.PowerId)
                    .HasName("PK_TPOWER");

                entity.ToTable("TPower");

                entity.Property(e => e.PowerId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HasSplitLine)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsLastLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsUseSsl)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MenuIcon)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PowerCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PowerName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PowerType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tprocess>(entity =>
            {
                entity.HasKey(e => e.ProcessId)
                    .HasName("PK_TPROCESS");

                entity.ToTable("TProcess");

                entity.Property(e => e.ProcessId).ValueGeneratedNever();

                entity.Property(e => e.Class1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Class2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessInstance>(entity =>
            {
                entity.HasKey(e => e.ProcessInstanceId)
                    .HasName("PK_TPROCESSINSTANCE");

                entity.ToTable("TProcessInstance");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EarliestDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.ProcessInstanceName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.RelavantData)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StardandDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK_TPROCESSPARAMETER");

                entity.ToTable("TProcessParameter");

                entity.Property(e => e.ParameterId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ParameterDescription)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ParameterType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ParameterUsage)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessSchedule>(entity =>
            {
                entity.HasKey(e => new { e.ProcessVersionId, e.ScheduleId })
                    .HasName("PK_TPROCESSSCHEDULE");

                entity.ToTable("TProcessSchedule");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessVersion>(entity =>
            {
                entity.HasKey(e => e.ProcessVersionId)
                    .HasName("PK_TPROCESSVERSION");

                entity.ToTable("TProcessVersion");

                entity.Property(e => e.ProcessVersionId).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutoExecute)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsCancelWhenExpired)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ProcessDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessInstanceName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VersionId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.XmlData).HasColumnType("text");
            });

            modelBuilder.Entity<TpublishedMessage>(entity =>
            {
                entity.HasKey(e => e.PublishedMessageId)
                    .HasName("PK_TPUBLISHEDMESSAGE");

                entity.ToTable("TPublishedMessage");

                entity.Property(e => e.PublishedMessageId).ValueGeneratedNever();

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsageDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UsageType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrebateMap>(entity =>
            {
                entity.HasKey(e => e.AdvancePaymentMapId)
                    .HasName("PK_TREBATEMAP");

                entity.ToTable("TRebateMap");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreceiverAccount>(entity =>
            {
                entity.HasKey(e => e.ReceiverAccountId)
                    .HasName("PK_TRECEIVERACCOUNT");

                entity.ToTable("TReceiverAccount");

                entity.Property(e => e.BankAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BankCity).HasMaxLength(50);

                entity.Property(e => e.BankProvince).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OpenBank)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceiverAccountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverAccountName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverBankAccount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverRemark).HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Treconciliation>(entity =>
            {
                entity.HasKey(e => e.ReconciliationId)
                    .HasName("PK_TRECONCILIATION");

                entity.ToTable("TReconciliation");

                entity.HasIndex(e => new { e.ReconciliationId, e.CustomerId, e.BranchId, e.CustomerCode, e.CustomerName, e.TotalAmount, e.IsGeneratedFile, e.IsSentMail, e.SendFailCount, e.FileName, e.ErrorMsg, e.GenerateStartTime, e.CreateUserId, e.CreateTime, e.UpdateUserId, e.UpdateTime, e.GenerateEndTime, e.CreateMonth, e.Status, e.CustomerReconciliationId })
                    .HasName("idx_TReconciliation_CreateMonth_Status_CustomerReconciliationId");

                entity.Property(e => e.ReconciliationId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ErrorMsg)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GenerateEndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GenerateStartTime).HasColumnType("datetime");

                entity.Property(e => e.IsGeneratedFile)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsNeedMerge)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSentMail)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreconciliationDetail>(entity =>
            {
                entity.HasKey(e => e.ReconciliationDetailId)
                    .HasName("PK_TRECONCILIATIONDETAIL");

                entity.ToTable("TReconciliationDetail");

                entity.HasIndex(e => new { e.ReconciliationId, e.Status })
                    .HasName("idx_TReconciliationDetail_ReconciliationId_Status");

                entity.Property(e => e.ReconciliationDetailId).ValueGeneratedNever();

                entity.Property(e => e.CostCenterCreateTime).HasColumnType("datetime");

                entity.Property(e => e.CostCenterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Freight).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrdererCreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrdererName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PurchaseRequestCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverCreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverName).HasMaxLength(100);

                entity.Property(e => e.ReferAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ReferCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReferType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.SaleOrderCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificatedAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.VerificationStatus)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TreconciliationExpand>(entity =>
            {
                entity.HasKey(e => e.ReconciliationExpandId)
                    .HasName("PK_TRECONCILIATIONEXPAND");

                entity.ToTable("TReconciliationExpand");

                entity.Property(e => e.BillFormat)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceReceiverFax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceReceiverMail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceReceiverMobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceReceiverName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsSendBillMail)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RecipientMail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreconciliationProduct>(entity =>
            {
                entity.HasKey(e => e.ReconciliationProductId)
                    .HasName("PK_TRECONCILIATIONPRODUCT");

                entity.ToTable("TReconciliationProduct");

                entity.HasIndex(e => new { e.ProductId, e.ProductCode, e.SaleUnit, e.Price, e.Quantity, e.TaxRate, e.ProductName, e.ReconciliationDetailId })
                    .HasName("TRecon_DetailId_NCL");

                entity.HasIndex(e => new { e.ReconciliationProductId, e.ReconciliationDetailId, e.ProductId, e.ProductCode, e.ProductFullName, e.Category1Name, e.Category2Name, e.Category3Name, e.SaleUnit, e.Price, e.Quantity, e.TaxRate, e.CreateUserId, e.CreateTime, e.UpdateUserId, e.UpdateTime, e.ProductName, e.ReconciliationId })
                    .HasName("idx_TReconciliationProduct_ReconciliationId");

                entity.Property(e => e.Category1Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Category2Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Category3Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductFullName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxCodeCategory)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrecordChange>(entity =>
            {
                entity.HasKey(e => e.ChangeId)
                    .HasName("PK_TRECORDCHANGE");

                entity.ToTable("TRecordChange");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TrecordChangeField>(entity =>
            {
                entity.HasKey(e => new { e.ChangeId, e.FieldName })
                    .HasName("PK_TRECORDCHANGEFIELD");

                entity.ToTable("TRecordChangeField");

                entity.Property(e => e.FieldName).HasMaxLength(255);

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<TrefundBill>(entity =>
            {
                entity.HasKey(e => e.RefundBillId)
                    .HasName("PK_TREFUNDBILL");

                entity.ToTable("TRefundBill");

                entity.Property(e => e.RefundBillId).ValueGeneratedNever();

                entity.Property(e => e.ActualRefundTime).HasColumnType("datetime");

                entity.Property(e => e.CancelAuditReason).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerManNote)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DoCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FinanceNote)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Freight).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ItemRefundAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiverAccountNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverBankName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RefundReason).HasMaxLength(200);

                entity.Property(e => e.RefundSource)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.RefundType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SoCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.TradeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TradeTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreplicationApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_TREPLICATIONAPPLICATION");

                entity.ToTable("TReplicationApplication");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ApplicationType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CommunicationKey)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CommunicationUserId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InterfaceBaseUrl)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsVerifyKey)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreplicationType>(entity =>
            {
                entity.HasKey(e => e.ReplicationTypeId)
                    .HasName("PK_TREPLICATIONTYPE");

                entity.ToTable("TReplicationType");

                entity.Property(e => e.ReplicationTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataQtyType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsForceReplicationAll)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PrepareClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReplicationAllDayTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ReplicationAllWeekDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.ReplicationTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WriteClassName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tschedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId)
                    .HasName("PK_TSCHEDULE");

                entity.ToTable("TSchedule");

                entity.Property(e => e.ScheduleId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DailyEndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.DailyFrequency)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DailyIntervalType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DailyOnceTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.DailyStartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InnerMonthValue)
                    .IsRequired()
                    .HasMaxLength(31);

                entity.Property(e => e.InnerWeekValue)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.IntervalType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.ScheduleName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UsageKeyValue)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsageType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TshortText>(entity =>
            {
                entity.HasKey(e => e.ShortTextId)
                    .HasName("PK_TSHORTTEXT");

                entity.ToTable("TShortText");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TextContent)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsiteReplication>(entity =>
            {
                entity.HasKey(e => e.ReplicationTypeId)
                    .HasName("PK_TSITEREPLICATION");

                entity.ToTable("TSiteReplication");

                entity.Property(e => e.ReplicationTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PrepareLastTime).HasColumnType("datetime");

                entity.Property(e => e.ReplicationAllLastTime).HasColumnType("datetime");

                entity.Property(e => e.ReplicationLastTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsmsFailed>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSFAILED")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSmsFailed");

                entity.Property(e => e.SmsId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FailDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.LastRetryTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsmsFormat>(entity =>
            {
                entity.HasKey(e => e.SmsFormatId)
                    .HasName("PK_TSMSFORMAT");

                entity.ToTable("TSmsFormat");

                entity.Property(e => e.SmsFormatId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SmsFormatCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.SmsFormatName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsmsReceivedPending>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSRECEIVEDPENDING");

                entity.ToTable("TSmsReceivedPending");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TsmsSent>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSSENT");

                entity.ToTable("TSmsSent");

                entity.Property(e => e.SmsId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsmsToSend>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSTOSEND");

                entity.ToTable("TSmsToSend");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsmsToSendTimer>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSTOSENDTIMER");

                entity.ToTable("TSmsToSendTimer");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpectedSendTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsysColsList>(entity =>
            {
                entity.HasKey(e => new { e.ColName, e.TableName })
                    .HasName("PK_TSYSCOLSLIST");

                entity.ToTable("TSysColsList");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.TableName).HasMaxLength(128);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClassPropertyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ColDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColNote)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsBool)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsDefaultSetByUser)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsGetByParent)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsNeedLanguage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequired)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MaxValue)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MinValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentGetMethodName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegExpression)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserDefaultValue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsysConfig>(entity =>
            {
                entity.HasKey(e => new { e.ConfigClass, e.ConfigName })
                    .HasName("PK_TSYSCONFIG");

                entity.ToTable("TSysConfig");

                entity.Property(e => e.ConfigClass).HasMaxLength(60);

                entity.Property(e => e.ConfigName).HasMaxLength(60);

                entity.Property(e => e.ConfigDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ConfigNote)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsReserved)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidateRegExpress)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TsysConfigClass>(entity =>
            {
                entity.HasKey(e => e.ConfigClass)
                    .HasName("PK_TSYSCONFIGCLASS");

                entity.ToTable("TSysConfigClass");

                entity.Property(e => e.ConfigClass)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigClassName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsysMaxNumber>(entity =>
            {
                entity.HasKey(e => new { e.ColName, e.TableName })
                    .HasName("PK_TSYSMAXNUMBER");

                entity.ToTable("TSysMaxNumber");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.TableName).HasMaxLength(128);

                entity.Property(e => e.ColNote)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsysStatus>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.ColName, e.CodeValue })
                    .HasName("PK_TSYSSTATUS");

                entity.ToTable("TSysStatus");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayValueEnglish)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusNote)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsysStatusLanguage>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.ColName, e.CodeValue, e.LanguageId })
                    .HasName("PK_TSYSSTATUSLANGUAGE");

                entity.ToTable("TSysStatusLanguage");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.CodeValue).HasMaxLength(60);

                entity.Property(e => e.LanguageId).HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DisplayValueEnglish)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StatusNote)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsysTablesList>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK_TSYSTABLESLIST");

                entity.ToTable("TSysTablesList");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAllowCache)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnableCache)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TableDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtaskType>(entity =>
            {
                entity.HasKey(e => e.TaskTypeId)
                    .HasName("PK_TTASKTYPE");

                entity.ToTable("TTaskType");

                entity.Property(e => e.TaskTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateHandled).HasColumnType("datetime");

                entity.Property(e => e.MaxId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TaskTypeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtimeLimit>(entity =>
            {
                entity.HasKey(e => e.TimeLimitId)
                    .HasName("PK_TTIMELIMIT");

                entity.ToTable("TTimeLimit");

                entity.Property(e => e.TimeLimitId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IntervalType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TimeLimtName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtoDoList>(entity =>
            {
                entity.HasKey(e => e.ToDoListId)
                    .HasName("PK_TTODOLIST");

                entity.ToTable("TToDoList");

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorInfo).HasColumnType("text");

                entity.Property(e => e.IsStoped)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastRetryTime).HasColumnType("datetime");

                entity.Property(e => e.NextRetryTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ToDoType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TtoDoListErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_TTODOLISTERRORLOG");

                entity.ToTable("TToDoListErrorLog");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorInfo)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsBatchToDoList)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TtoDoListHistory>(entity =>
            {
                entity.HasKey(e => e.ToDoListId)
                    .HasName("PK_TTODOLISTHISTORY")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TToDoListHistory");

                entity.Property(e => e.ToDoListId).ValueGeneratedNever();

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateProcessed).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ToDoType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TtoDoType>(entity =>
            {
                entity.HasKey(e => e.ToDoTypeId)
                    .HasName("PK_TTODOTYPE");

                entity.ToTable("TToDoType");

                entity.Property(e => e.ToDoTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateNoticed).HasColumnType("smalldatetime");

                entity.Property(e => e.EventNoticeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsAlertWhenDelay)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ToDoTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_TUSER");

                entity.ToTable("TUser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CompanyPhoneNo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Field1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field2)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field3)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.HomePhoneNo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsFromAd)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsRestrictIp)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PwdExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TuserIp>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.IpAddress })
                    .HasName("PK_TUSERIP");

                entity.ToTable("TUserIp");

                entity.Property(e => e.IpAddress).HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserLogin>(entity =>
            {
                entity.HasKey(e => e.UserLoginId)
                    .HasName("PK_TUSERLOGIN");

                entity.ToTable("TUserLogin");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.ServerIpAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserIpAddress)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TuserPasswordHistory>(entity =>
            {
                entity.HasKey(e => e.UserPasswordHistoryId)
                    .HasName("PK_TUSERPASSWORDHISTORY");

                entity.ToTable("TUserPasswordHistory");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NewPwd)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.OldPwd)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TuserPosition>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PositionId })
                    .HasName("PK_TUSERPOSITION");

                entity.ToTable("TUserPosition");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Field1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field2)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field3)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsPlurality)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserProfile>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ProfileType })
                    .HasName("PK_TUSERPROFILE");

                entity.ToTable("TUserProfile");

                entity.Property(e => e.ProfileType).HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProfileValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserRelation>(entity =>
            {
                entity.HasKey(e => new { e.ParentUserId, e.ChildUserId, e.OccupationId })
                    .HasName("PK_TUSERRELATION");

                entity.ToTable("TUserRelation");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TverificationFund>(entity =>
            {
                entity.HasKey(e => e.VerificationFundId)
                    .HasName("PK_TVERIFICATIONFUND");

                entity.ToTable("TVerificationFund");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FundSort)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationAmount).HasColumnType("decimal(19, 8)");
            });

            modelBuilder.Entity<TverificationGroup>(entity =>
            {
                entity.HasKey(e => e.VerificationGroupId)
                    .HasName("PK_TVERIFICATIONGROUP");

                entity.ToTable("TVerificationGroup");

                entity.Property(e => e.VerificationGroupId).ValueGeneratedNever();

                entity.Property(e => e.ActualReceivablesAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DifferenceReason)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceivablesAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.RefuseReason)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TverificationGroupDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK_TVERIFICATIONGROUPDETAIL");

                entity.ToTable("TVerificationGroupDetail");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(20);

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.ReferAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ReferCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReferType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationAmount).HasColumnType("decimal(19, 8)");
            });
        }
    }
}
