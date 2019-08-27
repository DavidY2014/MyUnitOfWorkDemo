using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class OnlineDBContext : DbContext
    {
        public OnlineDBContext()
        {
        }

        public OnlineDBContext(DbContextOptions<OnlineDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountLog> AccountLog { get; set; }
        public virtual DbSet<AdPositionTd> AdPositionTd { get; set; }
        public virtual DbSet<AdType> AdType { get; set; }
        public virtual DbSet<AdvancedExtendMasterTd> AdvancedExtendMasterTd { get; set; }
        public virtual DbSet<AdvancedFund> AdvancedFund { get; set; }
        public virtual DbSet<AdvancedOrderVerification> AdvancedOrderVerification { get; set; }
        public virtual DbSet<AdvancedReceivedVerification> AdvancedReceivedVerification { get; set; }
        public virtual DbSet<AdvertiseSlotTd> AdvertiseSlotTd { get; set; }
        public virtual DbSet<AdvertisingContentTd> AdvertisingContentTd { get; set; }
        public virtual DbSet<AdvertisingPositionTd> AdvertisingPositionTd { get; set; }
        public virtual DbSet<AdvisoryArticleTd> AdvisoryArticleTd { get; set; }
        public virtual DbSet<ApiOrderDetail> ApiOrderDetail { get; set; }
        public virtual DbSet<ApiOrderDetailRepProduct> ApiOrderDetailRepProduct { get; set; }
        public virtual DbSet<ApiOrderMaster> ApiOrderMaster { get; set; }
        public virtual DbSet<ApiOrderMasterExtend> ApiOrderMasterExtend { get; set; }
        public virtual DbSet<ApiOrderMasterVendor> ApiOrderMasterVendor { get; set; }
        public virtual DbSet<ApiOrderSequence> ApiOrderSequence { get; set; }
        public virtual DbSet<ApiRodetail> ApiRodetail { get; set; }
        public virtual DbSet<ApiRomaster> ApiRomaster { get; set; }
        public virtual DbSet<Apisostatus> Apisostatus { get; set; }
        public virtual DbSet<AreaRef> AreaRef { get; set; }
        public virtual DbSet<AreaSequenceTd> AreaSequenceTd { get; set; }
        public virtual DbSet<ArticleGroupTd> ArticleGroupTd { get; set; }
        public virtual DbSet<ArticleThemeGroup> ArticleThemeGroup { get; set; }
        public virtual DbSet<ArticleThemeTd> ArticleThemeTd { get; set; }
        public virtual DbSet<AsnItem> AsnItem { get; set; }
        public virtual DbSet<AsnMaster> AsnMaster { get; set; }
        public virtual DbSet<AsnSequence> AsnSequence { get; set; }
        public virtual DbSet<AsnTemp> AsnTemp { get; set; }
        public virtual DbSet<AsyncEmail> AsyncEmail { get; set; }
        public virtual DbSet<AsyncEmailAdditionalTd> AsyncEmailAdditionalTd { get; set; }
        public virtual DbSet<AsyncEmailHistorical> AsyncEmailHistorical { get; set; }
        public virtual DbSet<AsyncEmailSequenceTd> AsyncEmailSequenceTd { get; set; }
        public virtual DbSet<AuditRecord> AuditRecord { get; set; }
        public virtual DbSet<BranchConfig> BranchConfig { get; set; }
        public virtual DbSet<Category1> Category1 { get; set; }
        public virtual DbSet<Category2> Category2 { get; set; }
        public virtual DbSet<Category3> Category3 { get; set; }
        public virtual DbSet<Category3ReviewItemSequenceTd> Category3ReviewItemSequenceTd { get; set; }
        public virtual DbSet<Category3ReviewItemTd> Category3ReviewItemTd { get; set; }
        public virtual DbSet<CategoryAttribute1Td> CategoryAttribute1Td { get; set; }
        public virtual DbSet<CategoryAttribute2OptionPmsSequenceTd> CategoryAttribute2OptionPmsSequenceTd { get; set; }
        public virtual DbSet<CategoryAttribute2OptionSequence> CategoryAttribute2OptionSequence { get; set; }
        public virtual DbSet<CategoryAttribute2OptionTd> CategoryAttribute2OptionTd { get; set; }
        public virtual DbSet<CategoryAttribute2PmsSequence> CategoryAttribute2PmsSequence { get; set; }
        public virtual DbSet<CategoryAttribute2SequenceTd> CategoryAttribute2SequenceTd { get; set; }
        public virtual DbSet<CategoryAttribute2Td> CategoryAttribute2Td { get; set; }
        public virtual DbSet<CategorySequenceTd> CategorySequenceTd { get; set; }
        public virtual DbSet<ChannelCustomerMapping> ChannelCustomerMapping { get; set; }
        public virtual DbSet<ChannelProductMapping> ChannelProductMapping { get; set; }
        public virtual DbSet<ChannelType> ChannelType { get; set; }
        public virtual DbSet<CmschannelConfig> CmschannelConfig { get; set; }
        public virtual DbSet<Color1> Color1 { get; set; }
        public virtual DbSet<Color2> Color2 { get; set; }
        public virtual DbSet<ColorSequenceTt> ColorSequenceTt { get; set; }
        public virtual DbSet<ContractOperatedLogTd> ContractOperatedLogTd { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<CouponConfig> CouponConfig { get; set; }
        public virtual DbSet<CouponRequest> CouponRequest { get; set; }
        public virtual DbSet<CouponSequence> CouponSequence { get; set; }
        public virtual DbSet<CurrencyTd> CurrencyTd { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAdditionalTd> CustomerAdditionalTd { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<CustomerContactInfoTd> CustomerContactInfoTd { get; set; }
        public virtual DbSet<CustomerContractMasterPreTd> CustomerContractMasterPreTd { get; set; }
        public virtual DbSet<CustomerContractMasterTd> CustomerContractMasterTd { get; set; }
        public virtual DbSet<CustomerDepartment> CustomerDepartment { get; set; }
        public virtual DbSet<CustomerExpand> CustomerExpand { get; set; }
        public virtual DbSet<CustomerGroupName> CustomerGroupName { get; set; }
        public virtual DbSet<CustomerOutsourceRule> CustomerOutsourceRule { get; set; }
        public virtual DbSet<CustomerPointLog> CustomerPointLog { get; set; }
        public virtual DbSet<CustomerPointLogOld> CustomerPointLogOld { get; set; }
        public virtual DbSet<CustomerPointRequest> CustomerPointRequest { get; set; }
        public virtual DbSet<CustomerRank> CustomerRank { get; set; }
        public virtual DbSet<CustomerRecommendProduct> CustomerRecommendProduct { get; set; }
        public virtual DbSet<CustomerRelationTd> CustomerRelationTd { get; set; }
        public virtual DbSet<CustomerSequenceTd> CustomerSequenceTd { get; set; }
        public virtual DbSet<CustomerSoAduit> CustomerSoAduit { get; set; }
        public virtual DbSet<CustomerStrategyTd> CustomerStrategyTd { get; set; }
        public virtual DbSet<CustomerVatinfo> CustomerVatinfo { get; set; }
        public virtual DbSet<DepartmentAddress> DepartmentAddress { get; set; }
        public virtual DbSet<DepartmentOperator> DepartmentOperator { get; set; }
        public virtual DbSet<DepartmentSequenceTd> DepartmentSequenceTd { get; set; }
        public virtual DbSet<DepartmentTd> DepartmentTd { get; set; }
        public virtual DbSet<DepartmentVat> DepartmentVat { get; set; }
        public virtual DbSet<DepartmentsTemp> DepartmentsTemp { get; set; }
        public virtual DbSet<DirectPoCloseApply> DirectPoCloseApply { get; set; }
        public virtual DbSet<DistributionTree> DistributionTree { get; set; }
        public virtual DbSet<DoConfirm> DoConfirm { get; set; }
        public virtual DbSet<DoConfirmCfg> DoConfirmCfg { get; set; }
        public virtual DbSet<DoInvoiceTd> DoInvoiceTd { get; set; }
        public virtual DbSet<DoItem> DoItem { get; set; }
        public virtual DbSet<DoItemSequence> DoItemSequence { get; set; }
        public virtual DbSet<DoMaster> DoMaster { get; set; }
        public virtual DbSet<DoPackageTd> DoPackageTd { get; set; }
        public virtual DbSet<DoSequence> DoSequence { get; set; }
        public virtual DbSet<DoWmslog> DoWmslog { get; set; }
        public virtual DbSet<DoprintSequenceTd> DoprintSequenceTd { get; set; }
        public virtual DbSet<EmailMailNotificationTd> EmailMailNotificationTd { get; set; }
        public virtual DbSet<EmailNoticeParametersTd> EmailNoticeParametersTd { get; set; }
        public virtual DbSet<EmailParametersTd> EmailParametersTd { get; set; }
        public virtual DbSet<EmailTemplatesTt> EmailTemplatesTt { get; set; }
        public virtual DbSet<EnterpriseType> EnterpriseType { get; set; }
        public virtual DbSet<ExceptionProduct> ExceptionProduct { get; set; }
        public virtual DbSet<FinanceIncomeGroupItem> FinanceIncomeGroupItem { get; set; }
        public virtual DbSet<FinanceIncomeGroupMasterTd> FinanceIncomeGroupMasterTd { get; set; }
        public virtual DbSet<FinanceInvoice> FinanceInvoice { get; set; }
        public virtual DbSet<FinanceInvoiceItem> FinanceInvoiceItem { get; set; }
        public virtual DbSet<FinanceInvoiceItemSequence> FinanceInvoiceItemSequence { get; set; }
        public virtual DbSet<FinanceInvoiceSequenceTd> FinanceInvoiceSequenceTd { get; set; }
        public virtual DbSet<FinanceNetPay> FinanceNetPay { get; set; }
        public virtual DbSet<FinancePopay> FinancePopay { get; set; }
        public virtual DbSet<FinancePopayItemTd> FinancePopayItemTd { get; set; }
        public virtual DbSet<FinanceReceipt> FinanceReceipt { get; set; }
        public virtual DbSet<FinanceReceiptItem> FinanceReceiptItem { get; set; }
        public virtual DbSet<FinanceReceiptSequenceTd> FinanceReceiptSequenceTd { get; set; }
        public virtual DbSet<FinanceSoIncomeItemSequenceTt> FinanceSoIncomeItemSequenceTt { get; set; }
        public virtual DbSet<FinanceSoIncomeItemTt> FinanceSoIncomeItemTt { get; set; }
        public virtual DbSet<FinanceSoIncomeVoucher> FinanceSoIncomeVoucher { get; set; }
        public virtual DbSet<FinanceSoincome> FinanceSoincome { get; set; }
        public virtual DbSet<FinanceSoincomeSequence> FinanceSoincomeSequence { get; set; }
        public virtual DbSet<FreightManArea> FreightManArea { get; set; }
        public virtual DbSet<FreightManAreaSequenceTd> FreightManAreaSequenceTd { get; set; }
        public virtual DbSet<GiftActivityItem> GiftActivityItem { get; set; }
        public virtual DbSet<GiftActivityItemSequence> GiftActivityItemSequence { get; set; }
        public virtual DbSet<GiftActivityMaster> GiftActivityMaster { get; set; }
        public virtual DbSet<GiftActivityMasterSequence> GiftActivityMasterSequence { get; set; }
        public virtual DbSet<GiftCard> GiftCard { get; set; }
        public virtual DbSet<GiftCardLog> GiftCardLog { get; set; }
        public virtual DbSet<GiftCardSoItemTt> GiftCardSoItemTt { get; set; }
        public virtual DbSet<GiftCardSoMasterTt> GiftCardSoMasterTt { get; set; }
        public virtual DbSet<GiftItemTd> GiftItemTd { get; set; }
        public virtual DbSet<GiftMasterTd> GiftMasterTd { get; set; }
        public virtual DbSet<GiftSequenceTd> GiftSequenceTd { get; set; }
        public virtual DbSet<GroupShoppingApplication> GroupShoppingApplication { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<InterfaceProtocolTd> InterfaceProtocolTd { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryStock> InventoryStock { get; set; }
        public virtual DbSet<InventoryStockBack> InventoryStockBack { get; set; }
        public virtual DbSet<InvoiceChenGuangTd> InvoiceChenGuangTd { get; set; }
        public virtual DbSet<InvoiceEtl> InvoiceEtl { get; set; }
        public virtual DbSet<InvoiceRef> InvoiceRef { get; set; }
        public virtual DbSet<InvoiceTaxCategoryCode> InvoiceTaxCategoryCode { get; set; }
        public virtual DbSet<LogicalWarehouseCompare> LogicalWarehouseCompare { get; set; }
        public virtual DbSet<MailNotificationAuditTd> MailNotificationAuditTd { get; set; }
        public virtual DbSet<MailNotificationTd> MailNotificationTd { get; set; }
        public virtual DbSet<ManufacturerOri> ManufacturerOri { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<OperatorCart> OperatorCart { get; set; }
        public virtual DbSet<OrderTrade> OrderTrade { get; set; }
        public virtual DbSet<OutsourceRule> OutsourceRule { get; set; }
        public virtual DbSet<PayTypeRef> PayTypeRef { get; set; }
        public virtual DbSet<PayTypeSequence> PayTypeSequence { get; set; }
        public virtual DbSet<PoItem> PoItem { get; set; }
        public virtual DbSet<PoMaster> PoMaster { get; set; }
        public virtual DbSet<PoSequence> PoSequence { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAssociateItemTd> ProductAssociateItemTd { get; set; }
        public virtual DbSet<ProductAssociateMasterTd> ProductAssociateMasterTd { get; set; }
        public virtual DbSet<ProductAssociateSequenceTd> ProductAssociateSequenceTd { get; set; }
        public virtual DbSet<ProductAttribute2Summary> ProductAttribute2Summary { get; set; }
        public virtual DbSet<ProductAttribute2Td> ProductAttribute2Td { get; set; }
        public virtual DbSet<ProductChannel> ProductChannel { get; set; }
        public virtual DbSet<ProductChannelSequence> ProductChannelSequence { get; set; }
        public virtual DbSet<ProductCompetitorsPrice> ProductCompetitorsPrice { get; set; }
        public virtual DbSet<ProductCompetitorsPriceSequence> ProductCompetitorsPriceSequence { get; set; }
        public virtual DbSet<ProductCost> ProductCost { get; set; }
        public virtual DbSet<ProductId> ProductId { get; set; }
        public virtual DbSet<ProductIdSequenceTd> ProductIdSequenceTd { get; set; }
        public virtual DbSet<ProductListTd> ProductListTd { get; set; }
        public virtual DbSet<ProductMatch> ProductMatch { get; set; }
        public virtual DbSet<ProductOnWayLog> ProductOnWayLog { get; set; }
        public virtual DbSet<ProductPrice> ProductPrice { get; set; }
        public virtual DbSet<ProductRelativeInfoTd> ProductRelativeInfoTd { get; set; }
        public virtual DbSet<ProductSaleTrend> ProductSaleTrend { get; set; }
        public virtual DbSet<ProductSaleTypeTd> ProductSaleTypeTd { get; set; }
        public virtual DbSet<ProductSequence> ProductSequence { get; set; }
        public virtual DbSet<ProductShipArea> ProductShipArea { get; set; }
        public virtual DbSet<ProductStatus> ProductStatus { get; set; }
        public virtual DbSet<ProductStockStateTd> ProductStockStateTd { get; set; }
        public virtual DbSet<ProductUpdateLog> ProductUpdateLog { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<ProductWholeSaleSetTd> ProductWholeSaleSetTd { get; set; }
        public virtual DbSet<PurchasePlanTd> PurchasePlanTd { get; set; }
        public virtual DbSet<QaTd> QaTd { get; set; }
        public virtual DbSet<RecommendProduct> RecommendProduct { get; set; }
        public virtual DbSet<RecommendedBrand> RecommendedBrand { get; set; }
        public virtual DbSet<ReconciliationItem> ReconciliationItem { get; set; }
        public virtual DbSet<ReconciliationMasterTd> ReconciliationMasterTd { get; set; }
        public virtual DbSet<ReviewBaseInfoTd> ReviewBaseInfoTd { get; set; }
        public virtual DbSet<ReviewMasterTd> ReviewMasterTd { get; set; }
        public virtual DbSet<ReviewRemarkTd> ReviewRemarkTd { get; set; }
        public virtual DbSet<ReviewReplyTd> ReviewReplyTd { get; set; }
        public virtual DbSet<ReviewSequenceTd> ReviewSequenceTd { get; set; }
        public virtual DbSet<ReviewStatisticTd> ReviewStatisticTd { get; set; }
        public virtual DbSet<RmaHandlerDepartment> RmaHandlerDepartment { get; set; }
        public virtual DbSet<RmaItem> RmaItem { get; set; }
        public virtual DbSet<RmaMaster> RmaMaster { get; set; }
        public virtual DbSet<RmaRegisterSequenceTd> RmaRegisterSequenceTd { get; set; }
        public virtual DbSet<RmaRegisterTd> RmaRegisterTd { get; set; }
        public virtual DbSet<RmaSequence> RmaSequence { get; set; }
        public virtual DbSet<RmaShiftTd> RmaShiftTd { get; set; }
        public virtual DbSet<RoExchange> RoExchange { get; set; }
        public virtual DbSet<RoExchangeItem> RoExchangeItem { get; set; }
        public virtual DbSet<RoItem> RoItem { get; set; }
        public virtual DbSet<RoItemReturn> RoItemReturn { get; set; }
        public virtual DbSet<RoItemSequence> RoItemSequence { get; set; }
        public virtual DbSet<RoMaster> RoMaster { get; set; }
        public virtual DbSet<RoRefund> RoRefund { get; set; }
        public virtual DbSet<RoSaleRuleItem> RoSaleRuleItem { get; set; }
        public virtual DbSet<RoSequence> RoSequence { get; set; }
        public virtual DbSet<SaleCountdownNewSequence> SaleCountdownNewSequence { get; set; }
        public virtual DbSet<SaleCountdownNewTd> SaleCountdownNewTd { get; set; }
        public virtual DbSet<SalePointDelayTd> SalePointDelayTd { get; set; }
        public virtual DbSet<SaleRuleItem> SaleRuleItem { get; set; }
        public virtual DbSet<SaleRuleMaster> SaleRuleMaster { get; set; }
        public virtual DbSet<SaleRuleMasterSequence> SaleRuleMasterSequence { get; set; }
        public virtual DbSet<SaleUnitMap> SaleUnitMap { get; set; }
        public virtual DbSet<SaleUnitOriTd> SaleUnitOriTd { get; set; }
        public virtual DbSet<SalesInvoiceGroupEtl> SalesInvoiceGroupEtl { get; set; }
        public virtual DbSet<SalesInvoiceGroupItemEtl> SalesInvoiceGroupItemEtl { get; set; }
        public virtual DbSet<SalesInvoiceGroupItemRef> SalesInvoiceGroupItemRef { get; set; }
        public virtual DbSet<SalesInvoiceGroupRef> SalesInvoiceGroupRef { get; set; }
        public virtual DbSet<SalesInvoiceGroupSequence> SalesInvoiceGroupSequence { get; set; }
        public virtual DbSet<SalesInvoiceImport> SalesInvoiceImport { get; set; }
        public virtual DbSet<SalesInvoiceOffice> SalesInvoiceOffice { get; set; }
        public virtual DbSet<SearchKeyRecommendTd> SearchKeyRecommendTd { get; set; }
        public virtual DbSet<ShipTypeAreaConfigTt> ShipTypeAreaConfigTt { get; set; }
        public virtual DbSet<ShipTypeAreaPrice> ShipTypeAreaPrice { get; set; }
        public virtual DbSet<ShipTypeAreaUnEtl> ShipTypeAreaUnEtl { get; set; }
        public virtual DbSet<ShipTypeAreaUnRefTd> ShipTypeAreaUnRefTd { get; set; }
        public virtual DbSet<ShipTypeExtend> ShipTypeExtend { get; set; }
        public virtual DbSet<ShipTypeHousePurchaseTt> ShipTypeHousePurchaseTt { get; set; }
        public virtual DbSet<ShipTypePayTypeUnEtl> ShipTypePayTypeUnEtl { get; set; }
        public virtual DbSet<ShipTypePayTypeUnRef> ShipTypePayTypeUnRef { get; set; }
        public virtual DbSet<ShipTypeRef> ShipTypeRef { get; set; }
        public virtual DbSet<ShipTypeSequence> ShipTypeSequence { get; set; }
        public virtual DbSet<ShowCategoryC3Td> ShowCategoryC3Td { get; set; }
        public virtual DbSet<ShowCategoryTd> ShowCategoryTd { get; set; }
        public virtual DbSet<Size1> Size1 { get; set; }
        public virtual DbSet<Size2> Size2 { get; set; }
        public virtual DbSet<SoAlipay> SoAlipay { get; set; }
        public virtual DbSet<SoGiftActivity> SoGiftActivity { get; set; }
        public virtual DbSet<SoInvoiceLog> SoInvoiceLog { get; set; }
        public virtual DbSet<SoItem> SoItem { get; set; }
        public virtual DbSet<SoItemSequence> SoItemSequence { get; set; }
        public virtual DbSet<SoItemUpdateHistory> SoItemUpdateHistory { get; set; }
        public virtual DbSet<SoMaster> SoMaster { get; set; }
        public virtual DbSet<SoMasterUpdateHistory> SoMasterUpdateHistory { get; set; }
        public virtual DbSet<SoNotification> SoNotification { get; set; }
        public virtual DbSet<SoOutOrder> SoOutOrder { get; set; }
        public virtual DbSet<SoSaleRule> SoSaleRule { get; set; }
        public virtual DbSet<SoSaleRuleSequenceTd> SoSaleRuleSequenceTd { get; set; }
        public virtual DbSet<SoSequence> SoSequence { get; set; }
        public virtual DbSet<SoValueAddedInvoice> SoValueAddedInvoice { get; set; }
        public virtual DbSet<SounDomasterMark> SounDomasterMark { get; set; }
        public virtual DbSet<SpecialPriceDiscount> SpecialPriceDiscount { get; set; }
        public virtual DbSet<SpecialPriceItem> SpecialPriceItem { get; set; }
        public virtual DbSet<SpecialPriceItemSequence> SpecialPriceItemSequence { get; set; }
        public virtual DbSet<SpecialPriceMaster> SpecialPriceMaster { get; set; }
        public virtual DbSet<SpecialPriceMasterSequence> SpecialPriceMasterSequence { get; set; }
        public virtual DbSet<SpecialProduct> SpecialProduct { get; set; }
        public virtual DbSet<SrMaster> SrMaster { get; set; }
        public virtual DbSet<StAdjust> StAdjust { get; set; }
        public virtual DbSet<StAdjustItem> StAdjustItem { get; set; }
        public virtual DbSet<StAdjustSequence> StAdjustSequence { get; set; }
        public virtual DbSet<StLend> StLend { get; set; }
        public virtual DbSet<StLendItem> StLendItem { get; set; }
        public virtual DbSet<StLendItemBarcode> StLendItemBarcode { get; set; }
        public virtual DbSet<StLendReturn> StLendReturn { get; set; }
        public virtual DbSet<StLendReturnSequence> StLendReturnSequence { get; set; }
        public virtual DbSet<StLendSequence> StLendSequence { get; set; }
        public virtual DbSet<StShift> StShift { get; set; }
        public virtual DbSet<StShiftItem> StShiftItem { get; set; }
        public virtual DbSet<StShiftItemSequence> StShiftItemSequence { get; set; }
        public virtual DbSet<StShiftSequence> StShiftSequence { get; set; }
        public virtual DbSet<StTransfer> StTransfer { get; set; }
        public virtual DbSet<StTransferItem> StTransferItem { get; set; }
        public virtual DbSet<StTransferSequence> StTransferSequence { get; set; }
        public virtual DbSet<StVirtual> StVirtual { get; set; }
        public virtual DbSet<StockOrderConfig> StockOrderConfig { get; set; }
        public virtual DbSet<StockRef> StockRef { get; set; }
        public virtual DbSet<StockSequence> StockSequence { get; set; }
        public virtual DbSet<Subscribe> Subscribe { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<SysConfig> SysConfig { get; set; }
        public virtual DbSet<SysConfigHandlerMaster> SysConfigHandlerMaster { get; set; }
        public virtual DbSet<SysConfigHandlerPath> SysConfigHandlerPath { get; set; }
        public virtual DbSet<SysConfigType> SysConfigType { get; set; }
        public virtual DbSet<SysDropDownItem> SysDropDownItem { get; set; }
        public virtual DbSet<SysDropDownMaster> SysDropDownMaster { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysMenu> SysMenu { get; set; }
        public virtual DbSet<SysMenuSequence> SysMenuSequence { get; set; }
        public virtual DbSet<SysOperationType> SysOperationType { get; set; }
        public virtual DbSet<SysOperationTypePrivilege> SysOperationTypePrivilege { get; set; }
        public virtual DbSet<SysPrivilege> SysPrivilege { get; set; }
        public virtual DbSet<SysProtocolSequenceTd> SysProtocolSequenceTd { get; set; }
        public virtual DbSet<SysProtocolTd> SysProtocolTd { get; set; }
        public virtual DbSet<SysRequestAccount> SysRequestAccount { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysRolePrivilege> SysRolePrivilege { get; set; }
        public virtual DbSet<SysSequence> SysSequence { get; set; }
        public virtual DbSet<SysStation> SysStation { get; set; }
        public virtual DbSet<SysSync> SysSync { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<SysUserCategory> SysUserCategory { get; set; }
        public virtual DbSet<SysUserFavoriteLink> SysUserFavoriteLink { get; set; }
        public virtual DbSet<SysUserOut> SysUserOut { get; set; }
        public virtual DbSet<SysUserOutSequence> SysUserOutSequence { get; set; }
        public virtual DbSet<SysUserPagePrivilege> SysUserPagePrivilege { get; set; }
        public virtual DbSet<SysUserRole> SysUserRole { get; set; }
        public virtual DbSet<TabnormalDataMonitor> TabnormalDataMonitor { get; set; }
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
        public virtual DbSet<TbrandRepl> TbrandRepl { get; set; }
        public virtual DbSet<TbusinessLogCompensatory> TbusinessLogCompensatory { get; set; }
        public virtual DbSet<TcityRepl> TcityRepl { get; set; }
        public virtual DbSet<TconsumptionExpand> TconsumptionExpand { get; set; }
        public virtual DbSet<TcouponBatch> TcouponBatch { get; set; }
        public virtual DbSet<TcouponBatchChj> TcouponBatchChj { get; set; }
        public virtual DbSet<TcouponDetail> TcouponDetail { get; set; }
        public virtual DbSet<TcouponDetailChj> TcouponDetailChj { get; set; }
        public virtual DbSet<TcouponGift> TcouponGift { get; set; }
        public virtual DbSet<TcouponGiftChj> TcouponGiftChj { get; set; }
        public virtual DbSet<TcouponUseStrategy> TcouponUseStrategy { get; set; }
        public virtual DbSet<TcouponUseStrategyChj> TcouponUseStrategyChj { get; set; }
        public virtual DbSet<TcustomerEtl> TcustomerEtl { get; set; }
        public virtual DbSet<TcustomerSettlementExpand> TcustomerSettlementExpand { get; set; }
        public virtual DbSet<TcustomerSettlementLog> TcustomerSettlementLog { get; set; }
        public virtual DbSet<TdataPublisher> TdataPublisher { get; set; }
        public virtual DbSet<TdataPublisherParameter> TdataPublisherParameter { get; set; }
        public virtual DbSet<TdataSubscription> TdataSubscription { get; set; }
        public virtual DbSet<TdataTrack> TdataTrack { get; set; }
        public virtual DbSet<Tdepartment> Tdepartment { get; set; }
        public virtual DbSet<Tdescription> Tdescription { get; set; }
        public virtual DbSet<TdescriptionType> TdescriptionType { get; set; }
        public virtual DbSet<TdistrictRepl> TdistrictRepl { get; set; }
        public virtual DbSet<TdynamicSql> TdynamicSql { get; set; }
        public virtual DbSet<TecsitePosition> TecsitePosition { get; set; }
        public virtual DbSet<TempUpdateB2bcart> TempUpdateB2bcart { get; set; }
        public virtual DbSet<TfileUpload> TfileUpload { get; set; }
        public virtual DbSet<TgoodsAttributeClassRepl> TgoodsAttributeClassRepl { get; set; }
        public virtual DbSet<TgoodsAttributeRepl> TgoodsAttributeRepl { get; set; }
        public virtual DbSet<TgoodsAttributeValueRepl> TgoodsAttributeValueRepl { get; set; }
        public virtual DbSet<TgpPromotionDetailRepl> TgpPromotionDetailRepl { get; set; }
        public virtual DbSet<TgpPromotionRepl> TgpPromotionRepl { get; set; }
        public virtual DbSet<Thandle> Thandle { get; set; }
        public virtual DbSet<ThandleType> ThandleType { get; set; }
        public virtual DbSet<TitemPictureRepl> TitemPictureRepl { get; set; }
        public virtual DbSet<TitemRelationGroupDetailRepl> TitemRelationGroupDetailRepl { get; set; }
        public virtual DbSet<TitemRelationGroupRepl> TitemRelationGroupRepl { get; set; }
        public virtual DbSet<TitemRepl> TitemRepl { get; set; }
        public virtual DbSet<TitemStatistic> TitemStatistic { get; set; }
        public virtual DbSet<Tlanguage> Tlanguage { get; set; }
        public virtual DbSet<TlogicalWarehouseRepl> TlogicalWarehouseRepl { get; set; }
        public virtual DbSet<TlongText> TlongText { get; set; }
        public virtual DbSet<TmailAttachment> TmailAttachment { get; set; }
        public virtual DbSet<TmailAudit> TmailAudit { get; set; }
        public virtual DbSet<TmailFailed> TmailFailed { get; set; }
        public virtual DbSet<TmailFormat> TmailFormat { get; set; }
        public virtual DbSet<TmailFormatAttachment> TmailFormatAttachment { get; set; }
        public virtual DbSet<TmailSent> TmailSent { get; set; }
        public virtual DbSet<TmailToSend> TmailToSend { get; set; }
        public virtual DbSet<TnodeSchedule> TnodeSchedule { get; set; }
        public virtual DbSet<TnoticeEvent> TnoticeEvent { get; set; }
        public virtual DbSet<TnoticeEventArgument> TnoticeEventArgument { get; set; }
        public virtual DbSet<TnoticeEventDataItem> TnoticeEventDataItem { get; set; }
        public virtual DbSet<TnoticeEventMessage> TnoticeEventMessage { get; set; }
        public virtual DbSet<TnoticeEventSubscription> TnoticeEventSubscription { get; set; }
        public virtual DbSet<TobjectPower> TobjectPower { get; set; }
        public virtual DbSet<TobjectUtilityApp> TobjectUtilityApp { get; set; }
        public virtual DbSet<Toccupation> Toccupation { get; set; }
        public virtual DbSet<ToperationChange> ToperationChange { get; set; }
        public virtual DbSet<ToperationChangeDetail> ToperationChangeDetail { get; set; }
        public virtual DbSet<ToutsourceRule> ToutsourceRule { get; set; }
        public virtual DbSet<ToutsourceRuleArea> ToutsourceRuleArea { get; set; }
        public virtual DbSet<ToutsourceRuleBrand> ToutsourceRuleBrand { get; set; }
        public virtual DbSet<ToutsourceRuleCategory> ToutsourceRuleCategory { get; set; }
        public virtual DbSet<ToutsourceRuleHandle> ToutsourceRuleHandle { get; set; }
        public virtual DbSet<ToutsourceRuleItemSku> ToutsourceRuleItemSku { get; set; }
        public virtual DbSet<ToutsourceRuleUsage> ToutsourceRuleUsage { get; set; }
        public virtual DbSet<ToutsourceTypeLevel> ToutsourceTypeLevel { get; set; }
        public virtual DbSet<TpayTypeRepl> TpayTypeRepl { get; set; }
        public virtual DbSet<TpictureTypeRepl> TpictureTypeRepl { get; set; }
        public virtual DbSet<Tposition> Tposition { get; set; }
        public virtual DbSet<TpositionLevel> TpositionLevel { get; set; }
        public virtual DbSet<Tpower> Tpower { get; set; }
        public virtual DbSet<TproductAttributeValueRepl> TproductAttributeValueRepl { get; set; }
        public virtual DbSet<TproductRepl> TproductRepl { get; set; }
        public virtual DbSet<TproductSkuCost> TproductSkuCost { get; set; }
        public virtual DbSet<TproductWarehouse> TproductWarehouse { get; set; }
        public virtual DbSet<TprovinceRepl> TprovinceRepl { get; set; }
        public virtual DbSet<TrabbitMqerror> TrabbitMqerror { get; set; }
        public virtual DbSet<TrackSnBase> TrackSnBase { get; set; }
        public virtual DbSet<TreceivedMessage> TreceivedMessage { get; set; }
        public virtual DbSet<TrecordChange> TrecordChange { get; set; }
        public virtual DbSet<TrecordChangeField> TrecordChangeField { get; set; }
        public virtual DbSet<TreplicationApplication> TreplicationApplication { get; set; }
        public virtual DbSet<TreplicationType> TreplicationType { get; set; }
        public virtual DbSet<TriggerDetail> TriggerDetail { get; set; }
        public virtual DbSet<TriggerTemplete> TriggerTemplete { get; set; }
        public virtual DbSet<Tschedule> Tschedule { get; set; }
        public virtual DbSet<TshipTypeRepl> TshipTypeRepl { get; set; }
        public virtual DbSet<TshipTypeReplicationRepl> TshipTypeReplicationRepl { get; set; }
        public virtual DbSet<TshortText> TshortText { get; set; }
        public virtual DbSet<TsiteReplication> TsiteReplication { get; set; }
        public virtual DbSet<TsmsFailed> TsmsFailed { get; set; }
        public virtual DbSet<TsmsFormat> TsmsFormat { get; set; }
        public virtual DbSet<TsmsReceivedPending> TsmsReceivedPending { get; set; }
        public virtual DbSet<TsmsSent> TsmsSent { get; set; }
        public virtual DbSet<TsmsToSend> TsmsToSend { get; set; }
        public virtual DbSet<TsmsToSendTimer> TsmsToSendTimer { get; set; }
        public virtual DbSet<Tsocoupon> Tsocoupon { get; set; }
        public virtual DbSet<TsomasterUnion> TsomasterUnion { get; set; }
        public virtual DbSet<TsysColsList> TsysColsList { get; set; }
        public virtual DbSet<TsysConfig> TsysConfig { get; set; }
        public virtual DbSet<TsysConfigClass> TsysConfigClass { get; set; }
        public virtual DbSet<TsysMaxNumber> TsysMaxNumber { get; set; }
        public virtual DbSet<TsysStatus> TsysStatus { get; set; }
        public virtual DbSet<TsysStatusLanguage> TsysStatusLanguage { get; set; }
        public virtual DbSet<TsysTablesList> TsysTablesList { get; set; }
        public virtual DbSet<TtaskType> TtaskType { get; set; }
        public virtual DbSet<TtoDoList> TtoDoList { get; set; }
        public virtual DbSet<TtoDoListErrorLog> TtoDoListErrorLog { get; set; }
        public virtual DbSet<TtoDoListHistory> TtoDoListHistory { get; set; }
        public virtual DbSet<TtoDoType> TtoDoType { get; set; }
        public virtual DbSet<TunitRepl> TunitRepl { get; set; }
        public virtual DbSet<Tuser> Tuser { get; set; }
        public virtual DbSet<TuserIp> TuserIp { get; set; }
        public virtual DbSet<TuserLogin> TuserLogin { get; set; }
        public virtual DbSet<TuserPasswordHistory> TuserPasswordHistory { get; set; }
        public virtual DbSet<TuserPosition> TuserPosition { get; set; }
        public virtual DbSet<TuserProfile> TuserProfile { get; set; }
        public virtual DbSet<TuserRelation> TuserRelation { get; set; }
        public virtual DbSet<TutilityApp> TutilityApp { get; set; }
        public virtual DbSet<TwarehouseDeliveryAreaRepl> TwarehouseDeliveryAreaRepl { get; set; }
        public virtual DbSet<TwarehousePosition> TwarehousePosition { get; set; }
        public virtual DbSet<TwarehouseRepl> TwarehouseRepl { get; set; }
        public virtual DbSet<TwarehouseShipTypeRepl> TwarehouseShipTypeRepl { get; set; }
        public virtual DbSet<UnspscCatalog> UnspscCatalog { get; set; }
        public virtual DbSet<Unsubscribe> Unsubscribe { get; set; }
        public virtual DbSet<UserOrderDailyReport> UserOrderDailyReport { get; set; }
        public virtual DbSet<UserStock> UserStock { get; set; }
        public virtual DbSet<VaApMap> VaApMap { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorAdvanceAmtItem> VendorAdvanceAmtItem { get; set; }
        public virtual DbSet<VendorReplenishmentDays> VendorReplenishmentDays { get; set; }
        public virtual DbSet<VendorSequence> VendorSequence { get; set; }
        public virtual DbSet<VerifySyncHistory> VerifySyncHistory { get; set; }
        public virtual DbSet<VipoleToNewCustomer> VipoleToNewCustomer { get; set; }
        public virtual DbSet<VipoleToNewCustomerAddress> VipoleToNewCustomerAddress { get; set; }
        public virtual DbSet<VipoleToNewCustomerDepartment> VipoleToNewCustomerDepartment { get; set; }
        public virtual DbSet<VipoleToNewCustomerVatInfo> VipoleToNewCustomerVatInfo { get; set; }
        public virtual DbSet<VipoleToNewOperator> VipoleToNewOperator { get; set; }
        public virtual DbSet<WaybillMaster> WaybillMaster { get; set; }
        public virtual DbSet<WebBulletin> WebBulletin { get; set; }
        public virtual DbSet<WishList> WishList { get; set; }
        public virtual DbSet<WmsDeliverNo> WmsDeliverNo { get; set; }
        public virtual DbSet<WorkdayTd> WorkdayTd { get; set; }

        // Unable to generate entity type for table 'dbo.tsysconfig_back'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sys_config_back'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMailFormat_back'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOForCustomer_PayAlgorithm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOForCustomer_PayBrowser'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Support_Item'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ParcelLog_ETL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zy_debang_0612'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TSaleOverItemSku_PossessInventory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GroupShoppingApplication_Sequence_TD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_PP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sys_Sequence_DBC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zy_linshi_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_DailySales'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StockTransaction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_PROPERTY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TApiRequestError'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Vendor_AdvanceAmt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SR_Item_TD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TApiRequestHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SR_Sequence'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=10.10.4.202;User ID=Test;Password=Test123456;database=OnlineDB;Min Pool Size=10;Max Pool Size=500;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccountLog>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Account_Log");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.OrderSysNo)
                    .HasName("Ncl_Index_OrderSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LogType).HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderAccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.OrderSysNo).HasMaxLength(20);
            });

            modelBuilder.Entity<AdPositionTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__AdPositi__EB33D9B14620B061");

                entity.ToTable("AdPosition_TD");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AdType>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__AdType__EB33D9B149F14145");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AdvancedExtendMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_AdvancedExtendMaster");

                entity.ToTable("AdvancedExtendMaster_TD");

                entity.Property(e => e.RestAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<AdvancedFund>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.HasIndex(e => new { e.Status, e.CustomerId, e.ProduceDate })
                    .HasName("idx_AdvancedFund_Status_CustomerID_ProduceDate");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customerName")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsReconciliation).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProduceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RestAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AdvancedOrderVerification>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_AdvancedDo_MasterVerification");

                entity.HasIndex(e => e.FinanceIncomeGroupMasterNo)
                    .HasName("idx_AdvancedOrderVerification_Finance_IncomeGroup_MasterNo");

                entity.HasIndex(e => new { e.OrderType, e.VerificationAmount, e.OrderSysNo, e.VerificationTime })
                    .HasName("IX_AdvancedOrderVerification_OOVV");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FinanceIncomeGroupMasterNo).HasColumnName("Finance_IncomeGroup_MasterNo");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdvancedReceivedVerification>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.HasIndex(e => new { e.FinanceIncomeGroupMasterNo, e.AdvancedFundSysNo })
                    .HasName("idx_AdvancedReceivedVerification_AdvancedFundSysNo");

                entity.Property(e => e.FinanceIncomeGroupMasterNo).HasColumnName("Finance_IncomeGroup_MasterNo");

                entity.Property(e => e.VerificationAmount).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<AdvertiseSlotTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK");

                entity.ToTable("AdvertiseSlot_TD");

                entity.HasIndex(e => e.AbandonUserSysNo)
                    .HasName("Ncl_Index_AbandonUserSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.ProductSysNoList).HasMaxLength(600);

                entity.Property(e => e.ShowForums).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<AdvertisingContentTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Advertising_Content");

                entity.ToTable("Advertising_Content_TD");

                entity.Property(e => e.AdLinkPageAddress).HasMaxLength(200);

                entity.Property(e => e.AdLinkTarget).HasDefaultValueSql("((1))");

                entity.Property(e => e.AdPic).HasMaxLength(200);

                entity.Property(e => e.AdSmallPic).HasMaxLength(200);

                entity.Property(e => e.AdTag).HasMaxLength(100);

                entity.Property(e => e.AdTextContent).HasMaxLength(500);

                entity.Property(e => e.AdTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImgAlt)
                    .HasColumnName("ImgALT")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderNum).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdvertisingPositionTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Advertising_Position_SysNo");

                entity.ToTable("Advertising_Position_TD");

                entity.HasIndex(e => e.Code)
                    .HasName("UQ_ADPOSI_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("UQ_ADPOSI_Name")
                    .IsUnique();

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AdType).HasDefaultValueSql("((1))");

                entity.Property(e => e.C1sysNo).HasColumnName("C1SysNo");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.ChannelType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContentFormat)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PageChannelSysNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdvisoryArticleTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_AdvisoryArticle")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("AdvisoryArticle_TD");

                entity.HasIndex(e => new { e.OrderNum, e.AdvisoryType, e.CreateDate })
                    .HasName("CIX_OAC")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.BrandName).HasMaxLength(128);

                entity.Property(e => e.C1sysNo).HasColumnName("C1SysNo");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.ChannelType).HasMaxLength(64);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Tag).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(256);
            });

            modelBuilder.Entity<ApiOrderDetail>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ORDERDETAIL");

                entity.ToTable("API_Order_Detail");

                entity.HasIndex(e => e.MasterSysNo)
                    .HasName("idx_API_Order_Detail_MasterSysNo");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromId)
                    .HasColumnName("FromID")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryTurnover)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.ItemTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Poid)
                    .HasColumnName("POID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasColumnName("ProductID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName).HasMaxLength(300);

                entity.Property(e => e.ProductUnit)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.StockSysNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.TransposeTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VendorCode).HasMaxLength(100);
            });

            modelBuilder.Entity<ApiOrderDetailRepProduct>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__API_Orde__EB33D9B177D99E34");

                entity.ToTable("API_Order_Detail_RepProduct");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.RepProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApiOrderMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ORDER");

                entity.ToTable("API_Order_Master");

                entity.HasIndex(e => e.CompanyCode)
                    .HasName("idx_API_Order_Master_CompanyCode");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("idx_API_Order_Master_CreateTime");

                entity.HasIndex(e => new { e.Status, e.Poid })
                    .HasName("idx_API_Order_Master_POID_Status");

                entity.HasIndex(e => new { e.Status, e.Type })
                    .HasName("idx_API_Order_Master_Status_Type");

                entity.HasIndex(e => new { e.Type, e.Poid })
                    .HasName("idx_API_Order_Master_Type_POID");

                entity.HasIndex(e => new { e.SysNo, e.CreateTime, e.FromId })
                    .HasName("idx_API_Order_Master_FromID");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CompanyCode).HasMaxLength(200);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(200);

                entity.Property(e => e.Desc).HasMaxLength(255);

                entity.Property(e => e.ElecEmail).HasMaxLength(50);

                entity.Property(e => e.EmailList).HasMaxLength(1000);

                entity.Property(e => e.ExpectHandleTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromId)
                    .HasColumnName("FromID")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.InvoiceBankAccount).HasMaxLength(100);

                entity.Property(e => e.InvoiceBankInfo).HasMaxLength(100);

                entity.Property(e => e.InvoiceCompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoicePhone).HasMaxLength(50);

                entity.Property(e => e.InvoiceTaxNum).HasMaxLength(50);

                entity.Property(e => e.LockDateTime).HasColumnType("datetime");

                entity.Property(e => e.LockReason).HasMaxLength(200);

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.OperatorUserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Poid)
                    .HasColumnName("POID")
                    .HasMaxLength(100);

                entity.Property(e => e.Receiver).HasMaxLength(100);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiverEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverMobie).HasMaxLength(50);

                entity.Property(e => e.ReceiverTelePhone).HasMaxLength(50);

                entity.Property(e => e.ReceiverZip).HasMaxLength(50);

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SourceType).HasDefaultValueSql("((14))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseApiproductPrice).HasColumnName("UseAPIProductPrice");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApiOrderMasterExtend>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__API_Orde__EB33D9B17BAA2F18");

                entity.ToTable("API_Order_Master_Extend");

                entity.Property(e => e.ApisomasterSysNo).HasColumnName("APISOMasterSysNo");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ColumnRemark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ColumnValue)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApiOrderMasterVendor>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__API_Orde__EB33D9B174090D50");

                entity.ToTable("API_Order_Master_Vendor");

                entity.HasIndex(e => new { e.ApisomasterSysNo, e.ProductSysNo })
                    .HasName("idx_API_Order_Master_Vendor_APISOMasterSysNo_ProductSysNo");

                entity.Property(e => e.ApisomasterSysNo).HasColumnName("APISOMasterSysNo");

                entity.Property(e => e.CommPoint).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PpmuserSysNo).HasColumnName("PPMUserSysNo");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApiOrderSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ORDERSEQUENCE");

                entity.ToTable("API_Order_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ApiRodetail>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__API_RODe__EB33D9B175F08A6B");

                entity.ToTable("API_RODetail");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasColumnName("ProductID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApiRomaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__API_ROMa__EB33D9B1721FF987");

                entity.ToTable("API_ROMaster");

                entity.Property(e => e.CompanyCode).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(200);

                entity.Property(e => e.Desc).HasMaxLength(255);

                entity.Property(e => e.EmailList).HasMaxLength(1000);

                entity.Property(e => e.FromId)
                    .HasColumnName("FromID")
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.PickUpAddress).HasMaxLength(200);

                entity.Property(e => e.PickUpContact).HasMaxLength(20);

                entity.Property(e => e.PickUpMobile).HasMaxLength(20);

                entity.Property(e => e.PickUpPhone).HasMaxLength(100);

                entity.Property(e => e.PickUpTime).HasColumnType("datetime");

                entity.Property(e => e.PickUpZip).HasMaxLength(20);

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasColumnName("POID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAccount).HasMaxLength(100);

                entity.Property(e => e.RefundAccountName).HasMaxLength(50);

                entity.Property(e => e.RefundBank).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Apisostatus>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_APIOrderMaster");

                entity.ToTable("APISOStatus");

                entity.HasIndex(e => e.ChannelSoid)
                    .HasName("idx_APISOStatus_ChannelSOID");

                entity.Property(e => e.ChannelSoid)
                    .IsRequired()
                    .HasColumnName("ChannelSOId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FromId).HasMaxLength(50);

                entity.Property(e => e.OrderTotalPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AreaRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Area");

                entity.ToTable("Area_REF");

                entity.HasIndex(e => e.CitySysNo)
                    .HasName("Ncl_Index_CitySysNo");

                entity.HasIndex(e => e.ProvinceSysNo)
                    .HasName("Ncl_Index_ProvinceSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CityName).HasMaxLength(20);

                entity.Property(e => e.DistrictName).HasMaxLength(200);

                entity.Property(e => e.DistrictShortName).HasMaxLength(200);

                entity.Property(e => e.Localcode).HasColumnName("localcode");

                entity.Property(e => e.OrderNumber).HasMaxLength(20);

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Sign).HasMaxLength(100);
            });

            modelBuilder.Entity<AreaSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_AREA_SEQUENCE");

                entity.ToTable("Area_Sequence_TD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArticleGroupTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ARTICLEGROUP");

                entity.ToTable("ArticleGroup_TD");

                entity.HasIndex(e => e.ArticleSysNo)
                    .HasName("Ncl_Index_ArticleSysNo");

                entity.HasIndex(e => e.GroupSysNo)
                    .HasName("Ncl_Index_GroupSysNo");
            });

            modelBuilder.Entity<ArticleThemeGroup>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ARTICLETHEMEGROUP");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.ThemeSysNo)
                    .HasName("Ncl_Index_ThemeSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(256);

                entity.Property(e => e.Note).HasColumnType("text");
            });

            modelBuilder.Entity<ArticleThemeTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ARTICLETHEME");

                entity.ToTable("ArticleTheme_TD");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsnItem>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("ASN_Item");

                entity.HasIndex(e => e.AsnsysNo)
                    .HasName("Ncl_Index_ASNSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.ReferSysNo)
                    .HasName("Ncl_Index_ReferSysNo");

                entity.Property(e => e.Asnqty).HasColumnName("ASNQty");

                entity.Property(e => e.AsnsysNo).HasColumnName("ASNSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DiffReason).HasMaxLength(500);

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShelveTime).HasColumnType("datetime");

                entity.Property(e => e.Shelveusersysno).HasColumnName("shelveusersysno");

                entity.Property(e => e.StockNo).HasMaxLength(20);

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.VatRate).HasColumnType("decimal(19, 8)");
            });

            modelBuilder.Entity<AsnMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("ASN_Master");

                entity.HasIndex(e => e.Asnid)
                    .HasName("idx_ASN_Master_ASNID");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.HasIndex(e => e.Wmsid)
                    .HasName("ix_ASN_Master_WMSID");

                entity.HasIndex(e => new { e.SysNo, e.ProductSaleType, e.StockSysNo, e.CreateTime })
                    .HasName("idx_ASN_Master_ProductSaleType_StockSysNo_CreateTime");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.Asnid)
                    .IsRequired()
                    .HasColumnName("ASNID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpRecDate).HasColumnType("datetime");

                entity.Property(e => e.ExportList).HasMaxLength(2000);

                entity.Property(e => e.FirstInTime).HasColumnType("datetime");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PickUpAddress).HasMaxLength(200);

                entity.Property(e => e.PickUpContact).HasMaxLength(100);

                entity.Property(e => e.PickUpMobile).HasMaxLength(100);

                entity.Property(e => e.PickUpPhone).HasMaxLength(100);

                entity.Property(e => e.PickUpTime).HasColumnType("datetime");

                entity.Property(e => e.PickUpZip).HasMaxLength(20);

                entity.Property(e => e.PointShipPrice).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.ReferId).HasColumnName("ReferID");

                entity.Property(e => e.SyncTime).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.Wmsid)
                    .HasColumnName("WMSID")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<AsnSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("ASN_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AsnTemp>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("ASN_Temp");

                entity.HasIndex(e => e.AsnsysNo)
                    .HasName("Ncl_Index_ASNSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.ReferSysNo)
                    .HasName("Ncl_Index_ReferSysNo");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.Property(e => e.AsnsysNo).HasColumnName("ASNSysNo");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<AsyncEmail>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.MailAddress).HasMaxLength(200);

                entity.Property(e => e.MailBody).HasColumnType("text");

                entity.Property(e => e.MailSubject).HasMaxLength(500);
            });

            modelBuilder.Entity<AsyncEmailAdditionalTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_AsyncEmail_Additional");

                entity.ToTable("AsyncEmail_Additional_TD");

                entity.HasIndex(e => e.AsyncEmailServerSysNo)
                    .HasName("Ncl_Index_AsyncEmailServerSysNo");

                entity.HasIndex(e => e.AsyncEmailSysNo)
                    .HasName("Ncl_Index_AsyncEmailSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AsyncEmailHistorical>(entity =>
            {
                entity.ToTable("AsyncEmail_Historical ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MailAddress).HasMaxLength(200);

                entity.Property(e => e.MailBody).HasColumnType("text");

                entity.Property(e => e.MailSubject).HasMaxLength(500);

                entity.Property(e => e.SendTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AsyncEmailSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_AsyncEmail_SEQUENCE");

                entity.ToTable("AsyncEmail_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AuditRecord>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__AuditRec__EB33D9B1239E4DCF");

                entity.HasIndex(e => e.SoId)
                    .HasName("idx_AuditRecord_SoId");

                entity.HasIndex(e => new { e.SoId, e.AuditorSysNo })
                    .HasName("idx_AuditRecord_AuditorSysNo");

                entity.Property(e => e.ActionCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(4000);

                entity.Property(e => e.SoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BranchConfig>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__BranchCo__EB33D9B17C6A147E");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReconciliationTemplateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Category1>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CATEGORY1");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BorderList).HasColumnName("BOrderList");

                entity.Property(e => e.BrandSearchKeyWord).HasMaxLength(1000);

                entity.Property(e => e.Bstatus).HasColumnName("BStatus");

                entity.Property(e => e.C1id)
                    .IsRequired()
                    .HasColumnName("C1ID")
                    .HasMaxLength(20);

                entity.Property(e => e.C1name)
                    .IsRequired()
                    .HasColumnName("C1Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ChannelShowType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1-1,2-1,3-1')");

                entity.Property(e => e.Gstatus).HasColumnName("GStatus");

                entity.Property(e => e.IntegralCoefficient).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralMultiples).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralName).HasMaxLength(200);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(256);

                entity.Property(e => e.SearchKeyWord).HasMaxLength(500);

                entity.Property(e => e.Seodescription)
                    .IsRequired()
                    .HasColumnName("SEODescription")
                    .HasMaxLength(200);

                entity.Property(e => e.Seokeyword)
                    .IsRequired()
                    .HasColumnName("SEOKeyword")
                    .HasMaxLength(150);

                entity.Property(e => e.Seotitle)
                    .IsRequired()
                    .HasColumnName("SEOTitle")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Category2>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CATEGORY2");

                entity.HasIndex(e => e.C1sysNo)
                    .HasName("Ncl_Index_C1SysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Bstatus).HasColumnName("BStatus");

                entity.Property(e => e.C1sysNo).HasColumnName("C1SysNo");

                entity.Property(e => e.C2id)
                    .IsRequired()
                    .HasColumnName("C2ID")
                    .HasMaxLength(20);

                entity.Property(e => e.C2name)
                    .IsRequired()
                    .HasColumnName("C2Name")
                    .HasMaxLength(200);

                entity.Property(e => e.CategorySameKeyWord).HasMaxLength(1000);

                entity.Property(e => e.ChannelShowType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1-1,2-1,3-1')");

                entity.Property(e => e.Gstatus).HasColumnName("GStatus");

                entity.Property(e => e.IntegralCoefficient).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralMultiples).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralName).HasMaxLength(200);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(256);

                entity.Property(e => e.Seodescription)
                    .IsRequired()
                    .HasColumnName("SEODescription")
                    .HasMaxLength(200);

                entity.Property(e => e.Seokeyword)
                    .IsRequired()
                    .HasColumnName("SEOKeyword")
                    .HasMaxLength(150);

                entity.Property(e => e.Seotitle)
                    .IsRequired()
                    .HasColumnName("SEOTitle")
                    .HasMaxLength(100);

                entity.HasOne(d => d.C1sysNoNavigation)
                    .WithMany(p => p.Category2)
                    .HasForeignKey(d => d.C1sysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORY_REFERENCE_CATEGORY3");
            });

            modelBuilder.Entity<Category3>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CATEGORY3");

                entity.HasIndex(e => e.C2sysNo)
                    .HasName("Ncl_Index_C2SysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BrandSearchKeyWord).HasMaxLength(1000);

                entity.Property(e => e.Bstatus).HasColumnName("BStatus");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.C3dmsweight)
                    .HasColumnName("C3DMSWeight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.C3id)
                    .IsRequired()
                    .HasColumnName("C3ID")
                    .HasMaxLength(20);

                entity.Property(e => e.C3inventoryCycleTime).HasColumnName("C3InventoryCycleTime");

                entity.Property(e => e.C3name)
                    .IsRequired()
                    .HasColumnName("C3Name")
                    .HasMaxLength(200);

                entity.Property(e => e.C3type)
                    .HasColumnName("C3Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChannelShowType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1-1,2-1,3-1')");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Gstatus).HasColumnName("GStatus");

                entity.Property(e => e.IntegralCoefficient).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralMultiples).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralName).HasMaxLength(200);

                entity.Property(e => e.IsGonlineShow).HasColumnName("IsGOnlineShow");

                entity.Property(e => e.IsThePlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(256);

                entity.Property(e => e.Seodescription)
                    .IsRequired()
                    .HasColumnName("SEODescription")
                    .HasMaxLength(200);

                entity.Property(e => e.Seokeyword)
                    .IsRequired()
                    .HasColumnName("SEOKeyword")
                    .HasMaxLength(150);

                entity.Property(e => e.Seotitle)
                    .IsRequired()
                    .HasColumnName("SEOTitle")
                    .HasMaxLength(100);

                entity.HasOne(d => d.C2sysNoNavigation)
                    .WithMany(p => p.Category3)
                    .HasForeignKey(d => d.C2sysNo)
                    .HasConstraintName("FK_CATEGORY_REFERENCE_CATEGORY");
            });

            modelBuilder.Entity<Category3ReviewItemSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category3_ReviewItem_SEQUENCE");

                entity.ToTable("Category3_ReviewItem_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Category3ReviewItemTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category3_ReviewItem");

                entity.ToTable("Category3_ReviewItem_TD");

                entity.HasIndex(e => e.C3sysNo)
                    .HasName("Ncl_Index_C3SysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.C3sysNoNavigation)
                    .WithMany(p => p.Category3ReviewItemTd)
                    .HasForeignKey(d => d.C3sysNo)
                    .HasConstraintName("FK_Category3_ReviewItem_Category3");
            });

            modelBuilder.Entity<CategoryAttribute1Td>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category_Attribute1");

                entity.ToTable("Category_Attribute1_TD");

                entity.HasIndex(e => e.C3sysNo)
                    .HasName("Ncl_Index_C3SysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Attribute1Id)
                    .IsRequired()
                    .HasColumnName("Attribute1ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Attribute1Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Attribute1Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.HasOne(d => d.C3sysNoNavigation)
                    .WithMany(p => p.CategoryAttribute1Td)
                    .HasForeignKey(d => d.C3sysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORY_REFERENCE_CATEGORY4");
            });

            modelBuilder.Entity<CategoryAttribute2OptionPmsSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Category__EB33D9B1063D977B");

                entity.ToTable("Category_Attribute2_Option_PMS_Sequence_TD");

                entity.HasIndex(e => new { e.CategoryId, e.AttributeId, e.AttributeValueId, e.SysNo })
                    .HasName("Category_Attribute2_Option_PMS_Sequence");

                entity.HasIndex(e => new { e.SysNo, e.CategoryId, e.AttributeValueId, e.AttributeId })
                    .HasName("Category_Attribute2_Option_PMS_Sequence_CAOPMSS_SCA");
            });

            modelBuilder.Entity<CategoryAttribute2OptionSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category_Attribute2_Option_SEQUENCE");

                entity.ToTable("Category_Attribute2_Option_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CategoryAttribute2OptionTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category_Attribute2_Option");

                entity.ToTable("Category_Attribute2_Option_TD");

                entity.HasIndex(e => e.Attribute2SysNo)
                    .HasName("Ncl_Index_Attribute2SysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Attribute2OptionName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsRecommend).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CategoryAttribute2PmsSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Category__EB33D9B1026D0697");

                entity.ToTable("Category_Attribute2_PMS_Sequence");
            });

            modelBuilder.Entity<CategoryAttribute2SequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category_Attribute2_SEQUENCE");

                entity.ToTable("Category_Attribute2_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CategoryAttribute2Td>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Category_Attribute2");

                entity.ToTable("Category_Attribute2_TD");

                entity.HasIndex(e => e.A1sysNo)
                    .HasName("Ncl_Index_A1SysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.A1sysNo).HasColumnName("A1SysNo");

                entity.Property(e => e.Attribute2Id)
                    .IsRequired()
                    .HasColumnName("Attribute2ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Attribute2Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Attribute2Type).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CategorySequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CATEGORY_SEQUENCE");

                entity.ToTable("Category_Sequence_TD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChannelCustomerMapping>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ChannelType_Customer_Mapping");

                entity.ToTable("Channel_Customer_Mapping");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChannelProductMapping>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Channel_Product_Mapping");

                entity.Property(e => e.ChannelProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsSyncApi).HasColumnName("IsSyncAPI");

                entity.Property(e => e.OppositeUnitOfMeasure).HasMaxLength(20);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChannelType>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Channel_Type");

                entity.Property(e => e.IsSyncApi).HasColumnName("IsSyncAPI");

                entity.Property(e => e.IsSyncWms).HasColumnName("IsSyncWMS");

                entity.Property(e => e.IsUseSearch).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<CmschannelConfig>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("CMSChannelConfig");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.ReferSysNo)
                    .HasName("Ncl_Index_ReferSysNo");

                entity.HasIndex(e => e.UpdateUserSysNo)
                    .HasName("Ncl_Index_UpdateUserSysNo");

                entity.Property(e => e.Cmstype).HasColumnName("CMSType");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Color1>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Color1Id)
                    .HasColumnName("Color1ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Color1Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Color2>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Color2Id)
                    .HasColumnName("Color2ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Color2Img).HasMaxLength(500);

                entity.Property(e => e.Color2Name).HasMaxLength(50);

                entity.HasOne(d => d.Color1SysNoNavigation)
                    .WithMany(p => p.Color2)
                    .HasForeignKey(d => d.Color1SysNo)
                    .HasConstraintName("FK_Color2_Color1");
            });

            modelBuilder.Entity<ColorSequenceTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_COLOR_SEQUENCE");

                entity.ToTable("Color_Sequence_TT");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContractOperatedLogTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Contract_Operated_Log");

                entity.ToTable("Contract_Operated_Log_TD");

                entity.Property(e => e.OperateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.HasIndex(e => e.CouponCode)
                    .HasName("Ncl_Index_Couponcode");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.UseCustomerSysNo)
                    .HasName("Ncl_Index_UseCustomerSysNo");

                entity.HasIndex(e => new { e.BatchNo, e.Status })
                    .HasName("batchNo_Status");

                entity.HasIndex(e => new { e.Status, e.Type, e.ValidTimeFrom, e.GiftProductSysNoCom, e.ValidTimeTo })
                    .HasName("ix_coupon_FTG");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CategoryManufactorySysNoCom).HasMaxLength(500);

                entity.Property(e => e.CategorySysNoCom).HasMaxLength(500);

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CouponId)
                    .IsRequired()
                    .HasColumnName("CouponID")
                    .HasMaxLength(20);

                entity.Property(e => e.CouponName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerUserCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.DetailLink).HasMaxLength(200);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GiftProductSysNoCom).HasMaxLength(200);

                entity.Property(e => e.IsEmailed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManufactorySysNoCom).HasMaxLength(500);

                entity.Property(e => e.ProductSysNoCom).HasMaxLength(4000);

                entity.Property(e => e.SaleAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SelectCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UseAreaSysNoCom).HasMaxLength(500);

                entity.Property(e => e.UseCustomerGradeCom).HasMaxLength(500);

                entity.Property(e => e.UsedTime).HasColumnType("datetime");

                entity.Property(e => e.ValidTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<CouponConfig>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_COUPONCONFIG");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt).HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CouponRequest>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.RequestUserSysNo)
                    .HasName("Ncl_Index_RequestUserSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.HasIndex(e => new { e.CouponCode, e.Status })
                    .HasName("Ncl_Index_CouponCode");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CouponCode).HasMaxLength(20);

                entity.Property(e => e.Execsql)
                    .HasColumnName("EXECSql")
                    .HasColumnType("text");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<CouponSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Coupon_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurrencyTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CURRENCY");

                entity.ToTable("Currency_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ListOrder)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('z')");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CUSTOMER");

                entity.HasIndex(e => e.CellPhone);

                entity.HasIndex(e => e.CmuserSysNo)
                    .HasName("Ncl_Index_CMUserSysNo");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("Customer_CustomerID")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerGroup, e.IsVipNewSite })
                    .HasName("idx_Customer_CustomerGroup_IsVipNewSite");

                entity.HasIndex(e => new { e.CustomerId, e.SysNo, e.Status, e.HmCustomerType })
                    .HasName("idx_Customer_Status_HmCustomerType");

                entity.HasIndex(e => new { e.SysNo, e.CustomerId, e.CompanyName, e.CompanyCode })
                    .HasName("idx_Customer_CompanyCode");

                entity.HasIndex(e => new { e.SysNo, e.CompanyName, e.Status, e.SaleMan, e.HmCustomerType })
                    .HasName("idx_Customer_Status_SaleMan_HmCustomerType");

                entity.HasIndex(e => new { e.CustomerId, e.CustomerName, e.IsVipNewSite, e.SysNo, e.SaleMan, e.HmCustomerType })
                    .HasName("idx_Custome_SaleMan_HmCustomerType");

                entity.HasIndex(e => new { e.CustomerName, e.ReceiveName, e.ReceiveContact, e.IsVipNewSite, e.CustomerId, e.HmCustomerType })
                    .HasName("Ncl_Index_CustomerName");

                entity.HasIndex(e => new { e.ReconciliationDay, e.IsVipNewSite, e.SysNo, e.CustomerGroup, e.CustomerId, e.CompanyName })
                    .HasName("ix_Customer_SCCC");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName).HasMaxLength(100);

                entity.Property(e => e.AccountNo).HasMaxLength(100);

                entity.Property(e => e.AccountPeriod).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.AccountType).HasDefaultValueSql("((3))");

                entity.Property(e => e.AddTaxTel).HasMaxLength(100);

                entity.Property(e => e.AddtaxNo).HasMaxLength(100);

                entity.Property(e => e.Aptype).HasColumnName("APType");

                entity.Property(e => e.Bank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

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

                entity.Property(e => e.CreditLine)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentAccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CustomerGroup).HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerLabel).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerType).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryRequirements).HasMaxLength(100);

                entity.Property(e => e.District).HasMaxLength(25);

                entity.Property(e => e.DwellAddress).HasMaxLength(200);

                entity.Property(e => e.DwellZip).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpNumber).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FreightDemand).HasMaxLength(100);

                entity.Property(e => e.HmCustomerType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Industry).HasMaxLength(100);

                entity.Property(e => e.InvalidReason).HasMaxLength(500);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.InvoiceAndBillingRequirement).HasMaxLength(1000);

                entity.Property(e => e.InvoiceArrivedTime).HasMaxLength(1000);

                entity.Property(e => e.IsFreeShipPay).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsManualRank).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrintAmt).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendInvoiceWithOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShareGiftActivity).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStaff).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.ParentCustomerSysNo).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.RegisterTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnRequest).HasMaxLength(100);

                entity.Property(e => e.SignOrderBack).HasDefaultValueSql("((1))");

                entity.Property(e => e.SourceDesc).HasMaxLength(30);

                entity.Property(e => e.SourceFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.SumCreditLine)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalFreeShipFee)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransitionDatetime).HasColumnType("datetime");

                entity.Property(e => e.UnitCode).HasMaxLength(50);

                entity.Property(e => e.ValidFreeShipFee)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Viprank)
                    .HasColumnName("VIPRank")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CustomerAdditionalTd>(entity =>
            {
                entity.HasKey(e => e.CustomerSysNo)
                    .HasName("PK_Customer_Additional");

                entity.ToTable("Customer_Additional_TD");

                entity.Property(e => e.CustomerSysNo).ValueGeneratedNever();

                entity.Property(e => e.BusinessLicense)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.EconomicType).HasDefaultValueSql("((0))");

                entity.Property(e => e.FirmSize).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(500);

                entity.Property(e => e.IsAudit).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCfca).HasColumnName("IsCFCA");

                entity.Property(e => e.ManProductType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredCapital)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectorType).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Customer_Address");

                entity.HasIndex(e => e.Address)
                    .HasName("idx_Customer_Address_Address");

                entity.HasIndex(e => e.AreaSysNo)
                    .HasName("Ncl_Index_AreaSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => new { e.OperatorId, e.Status })
                    .HasName("ix_customer_address_OS");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Brief).HasMaxLength(100);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(100);

                entity.Property(e => e.DistributionCode).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerContactInfoTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Customer__EB33D9B103A0569B");

                entity.ToTable("CustomerContactInfo_TD");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactPhoneNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddr)
                    .IsRequired()
                    .HasColumnName("IPAddr")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerContractMasterPreTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CUSTOMER_CONTRACT_MASTER_Pre");

                entity.ToTable("Customer_Contract_Master_Pre_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AgreementEndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AgreementStartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContractEndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContractStartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeadLineNoticeDays)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HasContractManage).HasDefaultValueSql("((1))");

                entity.Property(e => e.NoticeEmail)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShareGroupId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerSysNoNavigation)
                    .WithMany(p => p.CustomerContractMasterPreTd)
                    .HasForeignKey(d => d.CustomerSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUSTOMER_REFERENCE_CUSTOMER_Pre");
            });

            modelBuilder.Entity<CustomerContractMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CUSTOMER_CONTRACT_MASTER");

                entity.ToTable("Customer_Contract_Master_TD");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_TCustomerContractMaster_Status");

                entity.HasIndex(e => e.UpdateUserSysNo)
                    .HasName("Ncl_Index_UpdateUserSysNo");

                entity.HasIndex(e => new { e.CustomerSysNo, e.Status })
                    .HasName("idx_TCustomerContractMaster_CustomerSysNo_Status");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AgreementEndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AgreementStartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContractEndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContractStartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeadLineNoticeDays)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.HasContractManage).HasDefaultValueSql("((1))");

                entity.Property(e => e.NoticeEmail)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShareGroupId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerDepartment>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CustomerDepartment_1");

                entity.ToTable("Customer_Department");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.FinancialContactAddressSysNo)
                    .HasName("Ncl_Index_FinancialContactAddressSysNo");

                entity.HasIndex(e => e.ParentDepartmentSysNo)
                    .HasName("IDX_Customer_Department_ParentDepartmentSysNo");

                entity.HasIndex(e => new { e.DepartmentName, e.SysNo, e.CustomerSysNo, e.AccountId })
                    .HasName("ix_Customer_Department_SCA");

                entity.HasIndex(e => new { e.SysNo, e.DepartmentName, e.Description, e.Status, e.ApprovalAmount, e.NextMonTime, e.NextIsYearAccumulate, e.NextYearBudget, e.NextYearTime, e.NextIsMonBudget, e.NextIsYearBudget, e.MonRemainder, e.MonRemainderUpdateDatetime, e.YearRemainder, e.YearRemainderUpdateDatetime, e.NextIsMonAccumulate, e.NextMonBudget, e.IsMonBudget, e.IsMonAccumulate, e.MonBudget, e.IsYearBudget, e.IsYearAccumulate, e.YearBudget, e.IsSendAccountEmail, e.DepartmentLevel, e.IsAudit, e.AccountId, e.IsOrderBudget, e.OrderBudget, e.CreateUserSysNo, e.IsAccountContact, e.InvoiceAddressSysNo, e.InvoiceAddress, e.DepartmentCompanyName, e.CustomerCode, e.BillingRequirements, e.DeliveryRequirements, e.PaymentRequest, e.UpdateTime, e.UpdateUserSysNo, e.CreateTime, e.FinancialContactFax, e.FinancialMailContact, e.FinancialContactAddressSysNo, e.FinancialContactAddress, e.FinancialZip, e.ReconciliationRequirements, e.CustomerSysNo, e.ContactPhone, e.ContactPerson, e.FinanceContacts, e.FinancialContactMobilePhone, e.FinancialContactPhone, e.ParentDepartmentSysNo })
                    .HasName("IDX_Customer_Department_ParentDepartmentSysNo_1");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ApprovalAmount)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingRequirements).HasMaxLength(100);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(200);

                entity.Property(e => e.DeliveryRequirements).HasMaxLength(100);

                entity.Property(e => e.DepartmentCompanyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DisPatchDayIndex).HasMaxLength(50);

                entity.Property(e => e.FinanceContacts).HasMaxLength(200);

                entity.Property(e => e.FinancialContactAddress).HasMaxLength(100);

                entity.Property(e => e.FinancialContactFax).HasMaxLength(50);

                entity.Property(e => e.FinancialContactMobilePhone).HasMaxLength(50);

                entity.Property(e => e.FinancialContactPhone).HasMaxLength(50);

                entity.Property(e => e.FinancialMailContact).HasMaxLength(50);

                entity.Property(e => e.FinancialZip).HasMaxLength(50);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.IsSendAccountEmail).HasDefaultValueSql("((1))");

                entity.Property(e => e.MonBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MonRemainder).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MonRemainderUpdateDatetime).HasColumnType("datetime");

                entity.Property(e => e.NextMonBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.NextMonTime).HasColumnType("datetime");

                entity.Property(e => e.NextYearBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.NextYearTime).HasColumnType("datetime");

                entity.Property(e => e.OrderBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PaymentRequest).HasMaxLength(100);

                entity.Property(e => e.ReconciliationRequirements).HasMaxLength(100);

                entity.Property(e => e.SentInvoiceAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoiceAreaSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SentInvoiceEmail)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoiceFax)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoiceMobilePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoiceName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoicePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoiceZip)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.YearBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.YearRemainder).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.YearRemainderUpdateDatetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerExpand>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Customer__EB33D9B144F84D55");

                entity.ToTable("Customer_Expand");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("idx_Customer_Expand_CustomerSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BdbonusDeadline)
                    .HasColumnName("BDbonusDeadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.BdbonusStartTime)
                    .HasColumnName("BDbonusStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerInvalidTime).HasColumnType("datetime");

                entity.Property(e => e.FirstSoorderTime)
                    .HasColumnName("FirstSOOrderTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupCustomerName).HasMaxLength(50);

                entity.Property(e => e.IsBdactivatedCustomer).HasColumnName("IsBDActivatedCustomer");

                entity.Property(e => e.IsBdbonusDeadlineChanged).HasColumnName("IsBDbonusDeadlineChanged");

                entity.Property(e => e.IsBdbonusStartTimeChanged).HasColumnName("IsBDbonusStartTimeChanged");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerGroupName>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Customer__EB33D9B140097B06");

                entity.ToTable("Customer_GroupName");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerOutsourceRule>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Customer__EB33D9B1531D1AD1");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerPointLog>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Customer__EB33D9B1411CCF79");

                entity.ToTable("Customer_PointLog");

                entity.HasIndex(e => e.ReceiptSysNo)
                    .HasName("idx_Customer_PointLog_ReceiptSysNo");

                entity.HasIndex(e => new { e.ReceiptSysNo, e.Status, e.PointLogType })
                    .HasName("idx_Customer_PointLog_PointLogType");

                entity.HasIndex(e => new { e.CustomerSysNo, e.PointLogType, e.Status, e.ReceiptSysNo })
                    .HasName("IX_CustomerPointLog_CPSR");

                entity.HasIndex(e => new { e.ReceiptSysNo, e.Status, e.PointLogType, e.PointLimitedDate })
                    .HasName("idx_Customer_PointLog_Status_PointLogType_PointLimitedDate");

                entity.HasIndex(e => new { e.SysNo, e.CustomerSysNo, e.PointLogType, e.Status })
                    .HasName("idx_Customer_PointLog_PointLogType_Status");

                entity.HasIndex(e => new { e.SysNo, e.PointAmount, e.ReceiptSysNo, e.Status, e.PointLogType })
                    .HasName("idx_Customer_PointLog_Status_PointLogType");

                entity.HasIndex(e => new { e.SysNo, e.PointAmount, e.PointLimitedDate, e.ReceiptSysNo, e.Status, e.PointLogType })
                    .HasName("idx_Customer_PointLog_Status_PointLogType_includ");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LogCheck).HasMaxLength(200);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.PointLimitedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptSysNo).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerPointLogOld>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CUSTOMER_POINTLOG");

                entity.ToTable("Customer_PointLog_old");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LogCheck)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PointLimitedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptSysNo).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerPointRequest>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Customer_PointRequest");

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.PmuserSysNo).HasColumnName("PMUserSysNo");

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<CustomerRank>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Customer_Rank");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CanGetPoint).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountPercent).HasDefaultValueSql("((100))");

                entity.Property(e => e.FloorAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RankName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TopAmount).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<CustomerRecommendProduct>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Customer_Recommend_Product");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("customer_recommend_product_customerSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerRelationTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__CustomerRelation__1");

                entity.ToTable("CustomerRelation_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OrgId).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<CustomerSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_CUSTOMER_SEQUENCE");

                entity.ToTable("Customer_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerSoAduit>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__customer__EB33D9B10507E572");

                entity.ToTable("customer_so_aduit");

                entity.Property(e => e.AduitDatetime).HasColumnType("datetime");

                entity.Property(e => e.CustomerDepartmentSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo).HasMaxLength(4000);
            });

            modelBuilder.Entity<CustomerStrategyTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Customer__EB33D9B10EB14B3D");

                entity.ToTable("CustomerStrategy_TD");

                entity.Property(e => e.Anid)
                    .HasColumnName("ANID")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckPower)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(20);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Editor).HasMaxLength(20);

                entity.Property(e => e.EnableTaxRate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LoginStrategy).HasMaxLength(50);

                entity.Property(e => e.PunchOutType).HasMaxLength(50);

                entity.Property(e => e.SoStrategy).HasMaxLength(50);

                entity.Property(e => e.UnSpsc)
                    .HasColumnName("UN_SPSC")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CustomerVatinfo>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Customer_VATInfo");

                entity.HasIndex(e => e.AddressSysNo)
                    .HasName("Ncl_Index_AddressSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => new { e.InvoiceType, e.CustomerDepartmentId, e.IsDefault })
                    .HasName("idx_Customer_VATInfo_IsDefault");

                entity.HasIndex(e => new { e.InvoiceType, e.IsDefault, e.CustomerDepartmentId })
                    .HasName("idx_Customer_VATInfo_IsDefault_CustomerDepartmentID");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.BankInfo).HasMaxLength(100);

                entity.Property(e => e.CompanyAddress).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(50);

                entity.Property(e => e.CompanySysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerDepartmentId).HasColumnName("CustomerDepartmentID");

                entity.Property(e => e.Image1).HasMaxLength(100);

                entity.Property(e => e.Image2).HasMaxLength(100);

                entity.Property(e => e.Image3).HasMaxLength(100);

                entity.Property(e => e.Image4).HasMaxLength(100);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.TaxNum).HasMaxLength(50);
            });

            modelBuilder.Entity<DepartmentAddress>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Departme__EB33D9B100433055");

                entity.ToTable("Department_Address");

                entity.HasIndex(e => new { e.AddressSysNo, e.DepartmentSysNo, e.IsValid })
                    .HasName("idx_Department_Address_DepartmentSysNo_IsValid");

                entity.HasIndex(e => new { e.DepartmentSysNo, e.AddressSysNo, e.IsValid })
                    .HasName("idx_Department_Address_IsValid");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DepartmentOperator>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Departme__EB33D9B161BEA935");

                entity.ToTable("Department_Operator");

                entity.HasIndex(e => e.Operator)
                    .HasName("idx_department_operator_customerSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DepartmentSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Department_SEQUENCE");

                entity.ToTable("Department_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DepartmentTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Department");

                entity.ToTable("Department_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<DepartmentVat>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Departme__EB33D9B17A8A56FF");

                entity.ToTable("Department_VAT");

                entity.HasIndex(e => new { e.DepartmentSysNo, e.VatsysNo, e.IsDefault, e.IsValid })
                    .HasName("idx_Department_VAT_IsValid");

                entity.HasIndex(e => new { e.VatsysNo, e.IsDefault, e.DepartmentSysNo, e.IsValid })
                    .HasName("idx_Department_VAT_DepartmentSysNo_IsValid");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VatsysNo).HasColumnName("VATSysNo");
            });

            modelBuilder.Entity<DepartmentsTemp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNumber).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<DirectPoCloseApply>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Direct_P__EB33D9B122F90663");

                entity.ToTable("Direct_PO_Close_Apply");

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PosysNo).HasColumnName("POSysNo");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.SignType).HasMaxLength(30);

                entity.Property(e => e.Status).HasDefaultValueSql("((10))");

                entity.Property(e => e.WayBillNo).HasMaxLength(500);
            });

            modelBuilder.Entity<DistributionTree>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Distribution_Tree");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.ChildMember).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserSysNo).HasMaxLength(100);

                entity.Property(e => e.Defalut1).HasMaxLength(100);

                entity.Property(e => e.Defalut3).HasColumnType("datetime");

                entity.Property(e => e.Member).HasMaxLength(10);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserSysNo).HasMaxLength(100);
            });

            modelBuilder.Entity<DoConfirm>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_CONFIRM");

                entity.ToTable("DO_Confirm");

                entity.HasIndex(e => new { e.Status, e.CreateTime, e.UpdateTime, e.DoSysNo })
                    .HasName("idx_DO_Confirm_DoSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoConfirmCfg>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_CONFIRM_CFG");

                entity.ToTable("DO_Confirm_cfg");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoInvoiceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_Invoice");

                entity.ToTable("DO_Invoice_TD");

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceCode).HasMaxLength(50);

                entity.Property(e => e.InvoiceNum).HasMaxLength(50);
            });

            modelBuilder.Entity<DoItem>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("DO_Item");

                entity.HasIndex(e => e.DosysNo)
                    .HasName("Ncl_Index_DOSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.ReferSysNo)
                    .HasName("Ncl_Index_ReferSysNo");

                entity.HasIndex(e => new { e.DosysNo, e.Quantity, e.SysNo, e.ProductSysNo })
                    .HasName("idx_DO_Item_ProductSysNo");

                entity.HasIndex(e => new { e.Cost, e.Price, e.Quantity, e.ReturnQty, e.DosysNo, e.ProductSysNo, e.ReferSysNo })
                    .HasName("ix_do_item");

                entity.HasIndex(e => new { e.Price, e.Quantity, e.ReturnQty, e.Cost, e.DosysNo, e.ProductSysNo, e.ReferSysNo })
                    .HasName("ix_DO_Item_001");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BalancePay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DosysNo).HasColumnName("DOSysNo");

                entity.Property(e => e.GiftCardPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Modal).HasMaxLength(100);

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.PointPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.ProductNote).HasMaxLength(4000);

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Specification).HasMaxLength(100);

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.Volume).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<DoItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_Item_SEQUENCE");

                entity.ToTable("DO_Item_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DoMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_MASTER");

                entity.ToTable("DO_Master");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.Doid)
                    .HasName("Ncl_Index_DOID");

                entity.HasIndex(e => e.ReceiveAreaSysNo)
                    .HasName("Ncl_Index_ReceiveAreaSysNo");

                entity.HasIndex(e => e.ShipTypeSysNo)
                    .HasName("Ncl_Index_ShipTypeSysNo");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.HasIndex(e => new { e.OutTime, e.StockSysNo })
                    .HasName("IX_DO_Master_001");

                entity.HasIndex(e => new { e.StockSysNo, e.SyncStatus, e.Status })
                    .HasName("ix_DO_Master_SSS");

                entity.HasIndex(e => new { e.ReferSysNo, e.ReferType, e.IsSign, e.Status })
                    .HasName("idx_DO_Master_ReferType_IsSign_Status");

                entity.HasIndex(e => new { e.SysNo, e.ReferSysNo, e.ReferType, e.IsReconciliation })
                    .HasName("idx_DO_Master_ReferType_IsReconciliation");

                entity.HasIndex(e => new { e.Doid, e.Status, e.CreateTime, e.SysNo, e.IsSyncToG7 })
                    .HasName("idx_DO_Master_IsSyncToG7");

                entity.HasIndex(e => new { e.SysNo, e.Doid, e.Status, e.ReferSysNo, e.ReferType })
                    .HasName("IX_DO_Master_002");

                entity.HasIndex(e => new { e.SysNo, e.VerificationTime, e.ReferType, e.IsReconciliation, e.Status })
                    .HasName("idx_DO_Master_ReferType_IsReconciliation_Status");

                entity.HasIndex(e => new { e.SignTime, e.Status, e.SysNo, e.CustomerDepartmentSysNo, e.Doid, e.IsSign })
                    .HasName("ix_DO_Master_C");

                entity.HasIndex(e => new { e.CustomerSysNo, e.SysNo, e.Doid, e.Status, e.ReferType, e.IsSign, e.SignTime })
                    .HasName("IX_DO_Master_ReferType_IsSign_SignTime");

                entity.HasIndex(e => new { e.SysNo, e.ReferType, e.CustomerSysNo, e.ReferSysNo, e.StockSysNo, e.IsSign, e.CreateTime, e.OutTime })
                    .HasName("idx_DO_Master_StockSysNo_IsSign_CreateTime_OutTime");

                entity.HasIndex(e => new { e.BranchSysNo, e.AggregateAmount, e.DepartmentCompanyName, e.TotalPoints, e.TotalUsePoints, e.EndAmt, e.ReferSysNo, e.InvoiceStatus, e.Status, e.OutTime, e.CustomerSysNo, e.InvoiceNo, e.IsReconciliation, e.SysNo, e.Doid, e.ShipPrice, e.ReceiveContact, e.ReceiveName, e.ReferType, e.IsSign, e.CustomerDepartmentSysNo, e.SignTime })
                    .HasName("idx_DO_Master_ReferType_IsSign_CustomerDepartmentSysNo_SignTime");

                entity.HasIndex(e => new { e.DistributionCode, e.EndAmt, e.ReferSysNo, e.BranchSysNo, e.CustomerSysNo, e.IsVisualStock, e.IsPrintPickupCover, e.IsReconciliation, e.OutUserSysNo, e.AggregateAmount, e.UpdateTime, e.IsSign, e.SignTime, e.ReceiveStatus, e.SyncTime, e.ReceiveTime, e.ReceiveCellPhone, e.ReceiveAddress, e.Status, e.SyncStatus, e.CreateUserSysNo, e.UpdateUserSysNo, e.SysNo, e.Doid, e.ReferType, e.ReceiveAreaSysNo, e.ReceiveContact, e.ReceivePhone, e.StockSysNo, e.CreateTime, e.OutTime })
                    .HasName("idx_DO_Master_StockSysNo_CreateTime_OutTime");

                entity.HasIndex(e => new { e.IsVisualStock, e.IsPrintPickupCover, e.IsReconciliation, e.OutUserSysNo, e.AggregateAmount, e.DistributionCode, e.IsSign, e.SignTime, e.ReceiveStatus, e.SyncTime, e.ReceiveTime, e.CustomerSysNo, e.ReceiveAddress, e.Status, e.SyncStatus, e.CreateUserSysNo, e.UpdateUserSysNo, e.UpdateTime, e.ReferType, e.StockSysNo, e.ReceiveAreaSysNo, e.ReceiveContact, e.ReceivePhone, e.ReceiveCellPhone, e.EndAmt, e.ReferSysNo, e.BranchSysNo, e.SysNo, e.Doid, e.CreateTime, e.OutTime })
                    .HasName("idx_DO_Master_CreateTime_OutTime");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.AggregateAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.CheckQtyTime).HasColumnType("datetime");

                entity.Property(e => e.Codamt)
                    .HasColumnName("CODAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryBillFileName).HasMaxLength(100);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCompanyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DistributionCode).HasMaxLength(200);

                entity.Property(e => e.DistributionRequireType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DlsysNo).HasColumnName("DLSysNo");

                entity.Property(e => e.Doid)
                    .IsRequired()
                    .HasColumnName("DOID")
                    .HasMaxLength(20);

                entity.Property(e => e.DownloadDeliveryBillStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ElecLink).HasMaxLength(500);

                entity.Property(e => e.EndAmt)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Exportlist)
                    .HasColumnName("EXPORTLIST")
                    .HasMaxLength(2000);

                entity.Property(e => e.Express).HasMaxLength(50);

                entity.Property(e => e.ExpressNo).HasMaxLength(50);

                entity.Property(e => e.ExpressWeight).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceDistributionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.IsAttachDeliveryBill).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsHaveInvoice).HasColumnName("isHaveInvoice");

                entity.Property(e => e.IsPreInvoice).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSyncToG7).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUploadDeliveryBill).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.PreInvoiceRemark).HasMaxLength(200);

                entity.Property(e => e.ProductInvoiceType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('默认明细')");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveCityId)
                    .HasColumnName("ReceiveCityID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiveContact).HasMaxLength(100);

                entity.Property(e => e.ReceiveName).HasMaxLength(100);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivePhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveProvinceId)
                    .HasColumnName("ReceiveProvinceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiveZip).HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.SetDeliveryManTime).HasColumnType("datetime");

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SignOperator).HasMaxLength(50);

                entity.Property(e => e.SignOrderBackType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.SyncTime).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("WarehouseID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wmsweight)
                    .HasColumnName("WMSWeight")
                    .HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<DoPackageTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_DO_PACKAGE");

                entity.ToTable("DO_Package_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DosysNo).HasColumnName("DOSysNo");

                entity.Property(e => e.PackageSize)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DoSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("DO_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoWmslog>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__DoWMSLog__EB33D9B168968F4D");

                entity.ToTable("DoWMSLog");

                entity.HasIndex(e => new { e.DoSysNo, e.Step })
                    .HasName("ix_DoWMSLog_DS");

                entity.HasIndex(e => new { e.CreateTime, e.DoId, e.Step })
                    .HasName("IX_DoWMSLog_DS2");

                entity.HasIndex(e => new { e.Messages, e.OperatorUser, e.SoSysNo, e.OperatorTime })
                    .HasName("ix_DoWMSLog_SoSysno");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DoId)
                    .HasColumnName("DoID")
                    .HasMaxLength(40);

                entity.Property(e => e.Messages)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OperatorTime).HasColumnType("datetime");

                entity.Property(e => e.OperatorUser).HasMaxLength(100);

                entity.Property(e => e.SoId)
                    .IsRequired()
                    .HasColumnName("SoID")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoprintSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__DOPrintS__EB33D9B13BC0BB7A");

                entity.ToTable("DOPrintSequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Doid)
                    .IsRequired()
                    .HasColumnName("DOID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailMailNotificationTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Email_Ma__EB33D9B16EEE8721");

                entity.ToTable("Email_MailNotification_TD");

                entity.Property(e => e.MailCharset)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailFromName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailServer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailUserPassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailNoticeParametersTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Email_Notice_Parameters");

                entity.ToTable("Email_Notice_Parameters_TD");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.MailCharset)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailFromName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailServer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailSubject)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MailTemplates)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.MailTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MailUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailUserPassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailParametersTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_EMAIL_PARAMETERS");

                entity.ToTable("Email_Parameters_TD");

                entity.Property(e => e.MailCharset)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailFromName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailServer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailUserPassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailTemplatesTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__EMailTemplates__711DBAFA");

                entity.ToTable("EMailTemplates_TT");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailBody).HasColumnType("text");

                entity.Property(e => e.Title).HasMaxLength(225);
            });

            modelBuilder.Entity<EnterpriseType>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Enterpri__EB33D9B11A37412B");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExceptionProduct>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ExceptionProductSEQUENCE");

                entity.ToTable("Exception_Product");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(300);

                entity.Property(e => e.SyncStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceIncomeGroupItem>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Finance_IncomeGroup_Item");

                entity.HasIndex(e => new { e.GroupSysNo, e.ReferSysNo, e.Type })
                    .HasName("idx_Finance_IncomeGroup_Item_Type");

                entity.HasIndex(e => new { e.ReferSysNo, e.GroupSysNo, e.Type })
                    .HasName("Finance_IncomeGroup_Item_GroupSysNo_Type");

                entity.Property(e => e.Amt).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<FinanceIncomeGroupMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Table_1_1");

                entity.ToTable("Finance_IncomeGroup_Master_TD");

                entity.HasIndex(e => new { e.SysNo, e.Status })
                    .HasName("Finance_IncomeGroup_Master_Status");

                entity.HasIndex(e => new { e.DepartmentName, e.CustomerGroup, e.CreateUserSysNo })
                    .HasName("Ncl_Index_Finance_IncomeGroup_Master");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AmountPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Diversity).HasMaxLength(200);

                entity.Property(e => e.PaidinPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceInvoice>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Finance_Invoice");

                entity.Property(e => e.SysNo)
                    .HasColumnName("sysNo")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FinanceReceiptSysNo).HasColumnName("Finance_ReceiptSysNo");

                entity.Property(e => e.IinvoiceId)
                    .HasColumnName("IinvoiceID")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceTitle)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.InvoiceType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiveAmt).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<FinanceInvoiceItem>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Finance_Invoice_Item");

                entity.Property(e => e.SysNo)
                    .HasColumnName("sysNo")
                    .ValueGeneratedNever();

                entity.Property(e => e.FsincomeSysNo).HasColumnName("FSIncomeSysNo");

                entity.Property(e => e.IinvoiceId).HasColumnName("IinvoiceID");

                entity.Property(e => e.InvoiceRatio).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.ReceiveAmt).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<FinanceInvoiceItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Finance_Invoice_Details_Sequence");

                entity.ToTable("Finance_Invoice_Item_Sequence");

                entity.Property(e => e.SysNo).HasColumnName("sysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceInvoiceSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Finance_Invoice_Sequence");

                entity.ToTable("Finance_Invoice_Sequence_TD");

                entity.Property(e => e.SysNo).HasColumnName("sysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceNetPay>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_FINANCE_NETPAY");

                entity.ToTable("Finance_NetPay");

                entity.HasIndex(e => e.PayTypeSysNo)
                    .HasName("Ncl_Index_PayTypeSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("uq_FinanceNetPay_SOSysNo")
                    .IsUnique();

                entity.Property(e => e.ApproveTime).HasColumnType("datetime");

                entity.Property(e => e.GcsysNo).HasColumnName("GCSysNo");

                entity.Property(e => e.GssysNo)
                    .HasColumnName("GSSysNo")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.InputTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PayAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<FinancePopay>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_FINANCE_POPAY");

                entity.ToTable("Finance_POPay");

                entity.HasIndex(e => e.CurrencySysNo)
                    .HasName("Ncl_Index_CurrencySysNo");

                entity.HasIndex(e => e.OrderSysNo)
                    .HasName("Ncl_Index_OrderSysNo");

                entity.HasIndex(e => e.PosysNo)
                    .HasName("Ncl_Index_POSysNo");

                entity.Property(e => e.AlreadyPayAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OrderSysNo).HasDefaultValueSql("((-999999))");

                entity.Property(e => e.OrderType).HasDefaultValueSql("((1))");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.Poamt)
                    .HasColumnName("POAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PosysNo).HasColumnName("POSysNo");

                entity.Property(e => e.StockInTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinancePopayItemTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_FINANCE_POPAY_ITEM");

                entity.ToTable("Finance_POPay_Item_TD");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EstimatePayTime).HasColumnType("datetime");

                entity.Property(e => e.IsPrintPopayBill).HasColumnName("IsPrintPOPayBill");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PayAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.PosysNo).HasColumnName("POSysNo");

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasMaxLength(20);

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.VoucherTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceReceipt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_FINANCE_RECEIPT");

                entity.ToTable("Finance_Receipt");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceiptId)
                    .IsRequired()
                    .HasColumnName("ReceiptID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiveAmt).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<FinanceReceiptItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Finance_Receipt___2EE5E349");

                entity.ToTable("Finance_Receipt_Item");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FsincomeSysNo).HasColumnName("FSIncomeSysNo");

                entity.Property(e => e.ReceiveAmt).HasColumnType("decimal(19, 6)");

                entity.HasOne(d => d.ReceiptSysNoNavigation)
                    .WithMany(p => p.FinanceReceiptItem)
                    .HasForeignKey(d => d.ReceiptSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Finance_R__Recei__2FDA0782");
            });

            modelBuilder.Entity<FinanceReceiptSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Finance_Receipt_Sequence");

                entity.ToTable("Finance_Receipt_Sequence_TD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceSoIncomeItemSequenceTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Finance_SoIncome_Item_SEQUENCE");

                entity.ToTable("Finance_SoIncome_Item_Sequence_TT");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FinanceSoIncomeItemTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Finance_SoIncome_Item");

                entity.ToTable("Finance_SoIncome_Item_TT");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FsisysNo).HasColumnName("FSISysNo");

                entity.Property(e => e.IncomeTime).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<FinanceSoIncomeVoucher>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Finance_SoIncome_Voucher");

                entity.HasIndex(e => e.FsisysNo)
                    .HasName("Ncl_Index_FSISysNo");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.FsisysNo).HasColumnName("FSISysNo");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasMaxLength(50);

                entity.Property(e => e.VoucherTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceSoincome>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Finance_SOIncome");

                entity.HasIndex(e => e.ConfirmUserSysNo)
                    .HasName("Ncl_Index_ConfirmUserSysNo");

                entity.HasIndex(e => e.IncomeUserSysNo)
                    .HasName("Ncl_Index_IncomeUserSysNo");

                entity.HasIndex(e => e.OrderType)
                    .HasName("Ncl_Index_OrderType");

                entity.HasIndex(e => e.ReferSysNo)
                    .HasName("Ncl_Index_ReferSysNo");

                entity.HasIndex(e => new { e.OrderSysNo, e.OrderType, e.Status })
                    .HasName("Ncl_Index_OrderSysNo_sysno");

                entity.HasIndex(e => new { e.Status, e.SysNo, e.OrderSysNo })
                    .HasName("idx_Finance_SOIncome_OrderSysNo");

                entity.HasIndex(e => new { e.SysNo, e.OrderType, e.OrderSysNo, e.Status })
                    .HasName("Ncl_Index_OrderSysNo");

                entity.HasIndex(e => new { e.OrderSysNo, e.OrderAmt, e.IncomeStyle, e.IncomeAmt, e.IncomeUserSysNo, e.ConfirmTime, e.ConfirmUserSysNo, e.Status, e.Aramt, e.ReferSysNo, e.SysNo, e.GiftCardAmt, e.Artime, e.OrderType, e.IncomeTime })
                    .HasName("idx_Finance_SOIncome_OrderType_IncomeTime");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Aramt)
                    .HasColumnName("ARAmt")
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Artime)
                    .HasColumnName("ARTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConfirmTime).HasColumnType("datetime");

                entity.Property(e => e.GiftCardAmt)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.IncomeAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IncomeTime).HasColumnType("datetime");

                entity.Property(e => e.LatestCollectionTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.OrderAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReceivedAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReferSysNo).HasDefaultValueSql("((-999999))");

                entity.Property(e => e.SaleAmt)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinanceSoincomeSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Finance_SOIncome_SEQUENCE");

                entity.ToTable("Finance_SOIncome_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FreightManArea>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("FreightMan_Area");

                entity.Property(e => e.SysNoId).HasColumnName("SysNoID");
            });

            modelBuilder.Entity<FreightManAreaSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_FreightMan_Area_SEQUENCE");

                entity.ToTable("FreightMan_Area_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GiftActivityItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_GIFTACTIVITY_ITEM");

                entity.ToTable("GiftActivity_Item");

                entity.HasIndex(e => new { e.ProductSysNo, e.Type })
                    .HasName("idx_GiftActivity_Item_ProductSysNo_Type");

                entity.HasIndex(e => new { e.SendQty, e.IsIconLoad, e.SysNo, e.ProductSysNo, e.ProductQty, e.Type, e.TotalQty, e.MasterSysNo })
                    .HasName("idx_GiftActivity_Item_MasterSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.IsIconLoad).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GiftActivityItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_GiftActivity_ITEM_SEQUENC");

                entity.ToTable("GiftActivity_Item_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GiftActivityMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_GIFTACTIVITY_MASTER");

                entity.ToTable("GiftActivity_Master");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChannelType).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsAddUp).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPromotionInfoShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.PromotionLink).HasMaxLength(200);

                entity.Property(e => e.PromotionWrods).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(500);

                entity.Property(e => e.WebPromotionTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<GiftActivityMasterSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_GiftActivity_Master_SEQUENC");

                entity.ToTable("GiftActivity_Master_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GiftCard>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.HasIndex(e => e.AbandonUserSysNo)
                    .HasName("Ncl_Index_AbandonUserSysNo");

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.BindCustomerSysNo)
                    .HasName("Ncl_Index_BindCustomerSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.LotSysNo)
                    .HasName("Ncl_Index_LotSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BindTime).HasColumnType("datetime");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("CardID")
                    .HasMaxLength(50);

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CardPwd)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LeftAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ValidFromDate).HasColumnType("datetime");

                entity.Property(e => e.ValidToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GiftCardLog>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("GiftCard_Log");

                entity.Property(e => e.GiftCardAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.LogTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GiftCardSoItemTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_GiftCardSO_ITEM")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("GiftCardSO_Item_TT");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BaseProductType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CdsysNo).HasColumnName("CDSysNo");

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponAmtApportion).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponAmtApportionForPm)
                    .HasColumnName("CouponAmtApportionForPM")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsCanVat).HasDefaultValueSql("((1))");

                entity.Property(e => e.Isinstall).HasColumnName("ISInstall");

                entity.Property(e => e.IsvirtualStock).HasColumnName("ISVirtualStock");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointType).HasDefaultValueSql("((2))");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('无')");

                entity.Property(e => e.ProductNote).HasMaxLength(4000);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.Volume).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.HasOne(d => d.SosysNoNavigation)
                    .WithMany(p => p.GiftCardSoItemTt)
                    .HasForeignKey(d => d.SosysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiftCardSO_ITEM_REFERENCE_SO_MASTE");
            });

            modelBuilder.Entity<GiftCardSoMasterTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_GiftCardSO_MASTER");

                entity.ToTable("GiftCardSO_Master_TT");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.AuditDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CashPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CheckQtyTime).HasColumnType("datetime");

                entity.Property(e => e.CmuserSysNo).HasColumnName("CMUserSysNo");

                entity.Property(e => e.CouponAmt)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponCode).HasMaxLength(50);

                entity.Property(e => e.CsuserSysNo).HasColumnName("CSUserSysNo");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMemo).HasMaxLength(200);

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DistributionRequireType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DlsysNo).HasColumnName("DLSysNo");

                entity.Property(e => e.ExpectDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Exportlist)
                    .HasColumnName("EXPORTLIST")
                    .HasMaxLength(2000);

                entity.Property(e => e.FreeShipFeePay)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GetPwdPhone).HasMaxLength(20);

                entity.Property(e => e.HasExpectQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasServiceProduct).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNote).HasMaxLength(500);

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.IsMergeSo).HasColumnName("IsMergeSO");

                entity.Property(e => e.IsVat).HasColumnName("IsVAT");

                entity.Property(e => e.IsreceiveSms).HasColumnName("ISReceiveSMS");

                entity.Property(e => e.ManagerAuditTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PayPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PosFee).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.PremiumAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveContact).HasMaxLength(20);

                entity.Property(e => e.ReceiveName).HasMaxLength(40);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivePhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveZip).HasMaxLength(20);

                entity.Property(e => e.RequestInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.SetDeliveryManTime).HasColumnType("datetime");

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShipPriceDosysNo).HasColumnName("ShipPriceDOSysNo");

                entity.Property(e => e.SignByOther).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.UploadPwd).HasMaxLength(50);

                entity.Property(e => e.Vatemsfee)
                    .HasColumnName("VATEMSFee")
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GiftItemTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Gift_Item");

                entity.ToTable("Gift_Item_TD");

                entity.HasIndex(e => e.GiftSysNo)
                    .HasName("Ncl_Index_GiftSysNo");

                entity.HasIndex(e => e.GmsysNo)
                    .HasName("Ncl_Index_GMSysNo");

                entity.Property(e => e.GmsysNo).HasColumnName("GMSysNo");
            });

            modelBuilder.Entity<GiftMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Gift_Master");

                entity.ToTable("Gift_Master_TD");

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ListOrder)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<GiftSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Gift_Sequence");

                entity.ToTable("Gift_Sequence_TD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupShoppingApplication>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.AliPayTradeNo).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.CompanyAddress).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributionRequireType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsamt)
                    .HasColumnName("GSAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Gsid)
                    .IsRequired()
                    .HasColumnName("GSID")
                    .HasMaxLength(20);

                entity.Property(e => e.Gsprice)
                    .HasColumnName("GSPrice")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Gsqty).HasColumnName("GSQty");

                entity.Property(e => e.GssysNo).HasColumnName("GSSysNo");

                entity.Property(e => e.InvoiceName).HasMaxLength(100);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.PayPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveContact)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(100);

                entity.Property(e => e.ReceivePhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveZip).HasMaxLength(50);

                entity.Property(e => e.ReturnPayTime).HasColumnType("datetime");

                entity.Property(e => e.Sex).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SocreateTime)
                    .HasColumnName("SOCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sonote)
                    .HasColumnName("SONote")
                    .HasMaxLength(200);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.TaxNum).HasMaxLength(20);
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_THOLIDAY");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Note).HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<InterfaceProtocolTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Interface_Protocol");

                entity.ToTable("Interface_Protocol_TD");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_INVENTORY");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => new { e.AccountQty, e.PurchaseQty, e.SalableQty, e.OrderQty, e.AvailableQty, e.ProductSysNo })
                    .HasName("Inventory_ProductSysNo");

                entity.Property(e => e.SalableQty).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InventoryStock>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_INVENTORY_STOCK");

                entity.ToTable("Inventory_Stock");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("IX_Inventory_ProductSysNo");

                entity.HasIndex(e => e.PurchaseQty)
                    .HasName("IX_PurchaseQty");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("IX_Inventory_Stock_SP");

                entity.HasIndex(e => new { e.ProductSysNo, e.StockSysNo, e.PurchaseQty })
                    .HasName("IX_ProductSysNo_Stock");

                entity.HasIndex(e => new { e.ProductSysNo, e.AccountQty, e.AvailableQty, e.StockSysNo })
                    .HasName("Ncl_Index_ProductSysNo_StockSysNo");

                entity.Property(e => e.PosLastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Position1).HasMaxLength(20);

                entity.Property(e => e.Position2).HasMaxLength(20);
            });

            modelBuilder.Entity<InventoryStockBack>(entity =>
            {
                entity.HasKey(e => new { e.StockSysNo, e.ProductSysNo, e.CreateTime });

                entity.ToTable("Inventory_Stock_Back");

                entity.HasIndex(e => new { e.AccountQty, e.UnitCost, e.ProductSysNo, e.CreateTime })
                    .HasName("IDX_Inventory_Stock_Back_ProductSysNo");

                entity.HasIndex(e => new { e.ProductSysNo, e.AccountQty, e.UnitCost, e.CreateTime })
                    .HasName("IDX_Inventory_Stock_Back_CreateTime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Position1).HasMaxLength(20);

                entity.Property(e => e.Position2).HasMaxLength(20);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(19, 8)");
            });

            modelBuilder.Entity<InvoiceChenGuangTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Invoice___EB33D9B12B5876E3");

                entity.ToTable("Invoice_ChenGuang_TD");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Doid)
                    .IsRequired()
                    .HasColumnName("DOID")
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvoiceEtl>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Invoice_ETL");

                entity.HasIndex(e => new { e.InvoiceNum, e.SignNum, e.Type })
                    .HasName("IX_Invoice_ETL_SignNum");

                entity.Property(e => e.Cash).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNum).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SignNum)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Type)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvoiceRef>(entity =>
            {
                entity.HasKey(e => e.Sysno)
                    .HasName("PK__Invoice__9BCDA7D0357DD23F");

                entity.ToTable("Invoice_REF");

                entity.HasIndex(e => new { e.InvoiceNum, e.SignNum, e.Type })
                    .HasName("IX_Invoice_IT");

                entity.Property(e => e.Sysno).HasColumnName("sysno");

                entity.Property(e => e.Cash).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNum).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.SignNum)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvoiceTaxCategoryCode>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TaxCategoryCode).HasMaxLength(30);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogicalWarehouseCompare>(entity =>
            {
                entity.HasKey(e => e.LogicalWarehouseId)
                    .HasName("PK__LogicalW__DE7946BA7E9C75B3");

                entity.ToTable("LogicalWarehouse_Compare");

                entity.Property(e => e.LogicalWarehouseId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutomaticAudit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsSyncWms)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LogicalWarehouseCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LogicalWarehouseName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogicalWarehouseType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postalcode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WmsWarehouseId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MailNotificationAuditTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__MailNoti__EB33D9B172BF1805");

                entity.ToTable("MailNotification_Audit_TD");

                entity.Property(e => e.AttemptCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<MailNotificationTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__MailNoti__EB33D9B17877F15B");

                entity.ToTable("MailNotification_TD");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("idx_MailNotification_CreateDate");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastSendDate).HasColumnType("datetime");

                entity.Property(e => e.MailAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MailBody).IsRequired();

                entity.Property(e => e.MailSubject)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SendCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ManufacturerOri>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_MANUFACTURER");

                entity.ToTable("Manufacturer_ORI");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsbrandImage).HasColumnName("ISBrandImage");

                entity.Property(e => e.Logo).HasMaxLength(200);

                entity.Property(e => e.ManufacturerId)
                    .IsRequired()
                    .HasColumnName("ManufacturerID")
                    .HasMaxLength(20);

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ManufacturerNameEn)
                    .HasColumnName("ManufacturerNameEN")
                    .HasMaxLength(100);

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(256);

                entity.Property(e => e.Note).HasColumnType("ntext");

                entity.Property(e => e.OrderNum).HasMaxLength(20);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100);

                entity.Property(e => e.Vendor).HasMaxLength(100);

                entity.Property(e => e.VendorSummary).HasMaxLength(200);
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.HasIndex(e => e.ContactAddressSysNo)
                    .HasName("Ncl_Index_ContactAddressSysNO");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("idx_Operator_CustomerSysNo");

                entity.HasIndex(e => e.DepartmentSysNo)
                    .HasName("Ncl_Index_DepartmentSysNo");

                entity.HasIndex(e => e.LoginId)
                    .HasName("loginIDUnique")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateUserSysNo)
                    .HasName("Ncl_Index_UpdateUserSysNo");

                entity.HasIndex(e => new { e.Status, e.LoginName, e.LoginId, e.NickName })
                    .HasName("ix_Operator_NIN");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ApprovalAmount)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cart).HasColumnType("text");

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.ContactAddress).HasMaxLength(100);

                entity.Property(e => e.ContactAddressSysNo).HasColumnName("ContactAddressSysNO");

                entity.Property(e => e.ContactMobilePhone).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactZip).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerStrategySysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.IsShowBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShowOffline).HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginName).HasMaxLength(100);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperatorName).HasMaxLength(100);

                entity.Property(e => e.OperatorPwd).HasMaxLength(50);

                entity.Property(e => e.OperatorShowModel).HasColumnType("text");

                entity.Property(e => e.SentInvoiceAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentInvoiceAddressSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OperatorCart>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SysNo");

                entity.HasIndex(e => new { e.OperatorSysNo, e.Status })
                    .HasName("ix_OperatorCart_OS");

                entity.Property(e => e.SysNo).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("SessionID")
                    .HasMaxLength(100);

                entity.Property(e => e.SoId)
                    .HasColumnName("SoID")
                    .HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderTrade>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Order_Trade");

                entity.Property(e => e.TradeId)
                    .IsRequired()
                    .HasColumnName("TradeID")
                    .HasMaxLength(20);

                entity.Property(e => e.TradeNo)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OutsourceRule>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Outsourc__EB33D9B14F4C89ED");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.CommPoint).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PpmuserSysNo).HasColumnName("PPMUserSysNo");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayTypeRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PAYTYPE");

                entity.ToTable("PayType_REF");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.IsInvoice).HasColumnName("isInvoice");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PayRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PayTypeDesc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PayTypeId)
                    .IsRequired()
                    .HasColumnName("PayTypeID")
                    .HasMaxLength(10);

                entity.Property(e => e.PayTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentPage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PayTypeSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PAYTYPE_SEQUENCE");

                entity.ToTable("PayType_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PoItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PO_ITEM");

                entity.ToTable("PO_Item");

                entity.HasIndex(e => e.PosysNo)
                    .HasName("Ncl_Index_POSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.ShelveUserSysNo)
                    .HasName("Ncl_Index_ShelveUserSysNo");

                entity.HasIndex(e => new { e.PosysNo, e.Quantity, e.OrderQty, e.ProductName, e.ProductSysNo })
                    .HasName("idx_PO_Item_ProductSysNo");

                entity.Property(e => e.ApportionAddOn).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.C3url)
                    .HasColumnName("C3URL")
                    .HasMaxLength(500);

                entity.Property(e => e.DailySales).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DefaultOrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Discount).HasMaxLength(10);

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PosysNo).HasColumnName("POSysNo");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QtyGap).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShelveTime).HasColumnType("datetime");

                entity.Property(e => e.StockNo).HasMaxLength(20);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.VendorOrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");

                entity.HasOne(d => d.PosysNoNavigation)
                    .WithMany(p => p.PoItem)
                    .HasForeignKey(d => d.PosysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PO_ITEM_REFERENCE_PO_MASTE");
            });

            modelBuilder.Entity<PoMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PO_MASTER");

                entity.ToTable("PO_Master");

                entity.HasIndex(e => e.ApportionUserSysNo)
                    .HasName("Ncl_Index_ApportionUserSysNo");

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.CurrencySysNo)
                    .HasName("Ncl_Index_CurrencySysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.InUserSysNo)
                    .HasName("Ncl_Index_InUserSysNo");

                entity.HasIndex(e => e.PayTypeSysNo)
                    .HasName("Ncl_Index_PayTypeSysNo");

                entity.HasIndex(e => e.Poid)
                    .HasName("IX_PO_Master_001");

                entity.HasIndex(e => e.PoshipTypeSysNo)
                    .HasName("Ncl_Index_POShipTypeSysNo");

                entity.HasIndex(e => e.ReceiveUserSysNo)
                    .HasName("Ncl_Index_ReceiveUserSysNo");

                entity.HasIndex(e => e.ShelveUserSysNo)
                    .HasName("Ncl_Index_ShelveUserSysNo");

                entity.HasIndex(e => e.ShipTypeSysNo)
                    .HasName("Ncl_Index_ShipTypeSysNo");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.HasIndex(e => e.VendorSysNo)
                    .HasName("Ncl_Index_VendorSysNo");

                entity.HasIndex(e => new { e.ReferSysNo, e.PurchaseType })
                    .HasName("idx_PO_Master_ReferSysNO_PurchaseType");

                entity.HasIndex(e => new { e.SysNo, e.StockSysNo, e.Status, e.ReceiveStatus })
                    .HasName("idx_PO_Master_StockSysNo_Status_ReceiveStatus");

                entity.HasIndex(e => new { e.InUserSysNo, e.PayDate, e.Status, e.ArrivalTime, e.ReceiveStatus, e.PoSourceId, e.StockSysNo, e.TotalAmt, e.CreateTime, e.AuditTime, e.AuditUserSysNo, e.InTime, e.Positive, e.SyncStatus, e.PurchaseType, e.SysNo, e.Poid, e.VendorSysNo, e.CreateUserSysNo, e.ProductSaleType })
                    .HasName("idx_PO_Master_CreateUserSysNo_ProductSaleType");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ApportionTime).HasColumnType("datetime");

                entity.Property(e => e.ArrivalTime).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.ContractNumber).HasMaxLength(100);

                entity.Property(e => e.ContractUrl).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ExportList).HasMaxLength(2000);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceExpectReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerAuditMemo).HasColumnType("text");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.MinusPotype).HasColumnName("MinusPOType");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PoSourceId)
                    .HasColumnName("PoSourceID")
                    .HasMaxLength(50);

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasColumnName("POID")
                    .HasMaxLength(20);

                entity.Property(e => e.PoinvoiceDunDesc)
                    .HasColumnName("POInvoiceDunDesc")
                    .HasColumnType("text");

                entity.Property(e => e.PoinvoiceType)
                    .HasColumnName("POInvoiceType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PoshipTypeSysNo).HasColumnName("POShipTypeSysNo");

                entity.Property(e => e.Potype)
                    .HasColumnName("POType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverAddress).HasMaxLength(100);

                entity.Property(e => e.ReceiverTelPhone).HasMaxLength(50);

                entity.Property(e => e.ReceiverUserName).HasMaxLength(100);

                entity.Property(e => e.ReferSysNo).HasColumnName("ReferSysNO");

                entity.Property(e => e.ShelveTime).HasColumnType("datetime");

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.VendorDeliveryStatus).HasMaxLength(1);

                entity.Property(e => e.VendorHandleStatus).HasMaxLength(1);
            });

            modelBuilder.Entity<PoSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PO_SEQUENCE");

                entity.ToTable("PO_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT");

                entity.HasIndex(e => e.C3sysNo)
                    .HasName("Product_C3SysNo");

                entity.HasIndex(e => e.LastVendorSysNo)
                    .HasName("Ncl_Index_LastVendorSysNo");

                entity.HasIndex(e => e.ManufacturerSysNo)
                    .HasName("Ncl_Index_ManufacturerSysNo");

                entity.HasIndex(e => e.ProductAssociateSysNo)
                    .HasName("Ncl_Index_ProductAssociateSysNo");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_Product");

                entity.HasIndex(e => new { e.ProductChannelShowType, e.SysNo, e.IsSaleOver })
                    .HasName("idx_Product_IsSaleOver");

                entity.HasIndex(e => new { e.SysNo, e.ProductId, e.C3sysNo })
                    .HasName("idx_Product_C3SysNo_INCLUDE");

                entity.HasIndex(e => new { e.C3sysNo, e.SaleQty, e.ProductChannelShowType, e.SysNo })
                    .HasName("IX_Product_V");

                entity.HasIndex(e => new { e.SysNo, e.ProductId, e.ProductType, e.C3sysNo })
                    .HasName("Ncl_Index_ProductType_C3SysNo");

                entity.HasIndex(e => new { e.SysNo, e.ProductName, e.ProductType, e.C3sysNo })
                    .HasName("idx_Product_ProductType_C3SysNo");

                entity.HasIndex(e => new { e.SysNo, e.IsPurchase, e.ProductChannelShowType, e.IsSaleStop, e.IsSaleOver })
                    .HasName("idx_Product_ProductChannelShowType_IsSaleStop_IsSaleOver");

                entity.HasIndex(e => new { e.IsSaleStop, e.SysNo, e.OnlineShowType, e.C3sysNo, e.Saleweekqty, e.ProductChannelShowType })
                    .HasName("idx_Product_C3SysNo_saleweekqty_ProductChannelShowType");

                entity.HasIndex(e => new { e.SysNo, e.C3sysNo, e.OnlineShowType, e.Saleweekqty, e.ProductChannelShowType, e.IsSaleStop })
                    .HasName("idx_Product_OnlineShowType_saleweekqty_ProductChannelShowType_IsSaleStop");

                entity.HasIndex(e => new { e.SysNo, e.ProductId, e.ProductName, e.PromotionWord, e.ProductMode, e.ManufacturerSysNo, e.PackingList, e.ProductChannelShowType, e.DefaultPurchasePrice, e.LastVendorSysNo, e.CreateTime, e.SaleUnit, e.MultiPicNum, e.BarCode, e.SaleOverProduct, e.UnSaleableDesc, e.ProductType, e.C3sysNo })
                    .HasName("Index_ProductType_C3SysNo");

                entity.HasIndex(e => new { e.PictureStatus, e.PriceStatus, e.ProductNameStatus, e.InventoryTurnover, e.IsSaleStop, e.IsSaleOver, e.IsReturnGoods, e.IsPurchase, e.IsPurchaseReturn, e.MerchandiseCode, e.PackingList, e.DescStatus, e.Dmsweight, e.Dms, e.Opl, e.DefaultPurchasePrice, e.IsInBuy, e.AttentionPercent, e.PmuserSysNo, e.CreateTime, e.BarCode, e.Status, e.LastVendorSysNo, e.InventoryCycleTime, e.SysNo, e.ProductId, e.ProductMode, e.ProductName, e.PromotionWord, e.C3sysNo, e.ProductType })
                    .HasName("Ncl_Index_ProductType");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ApmuserSysNo).HasColumnName("APMUserSysNo");

                entity.Property(e => e.AssessmentLink).HasMaxLength(200);

                entity.Property(e => e.AssessmentTitle).HasMaxLength(200);

                entity.Property(e => e.Attention).HasMaxLength(500);

                entity.Property(e => e.AttentionPercent).HasDefaultValueSql("((1))");

                entity.Property(e => e.AvgDailyClick).HasDefaultValueSql("((5))");

                entity.Property(e => e.Avgscore).HasDefaultValueSql("((3))");

                entity.Property(e => e.BarCode).HasMaxLength(30);

                entity.Property(e => e.BiddingDesc).HasMaxLength(2000);

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BuyingGuideIcon).HasMaxLength(50);

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.ConvertUnit).HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DayAvgSaleQty1).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DayAvgSaleQty2).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DefaultPurchasePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DescStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Dms)
                    .HasColumnName("DMS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dmsweight)
                    .HasColumnName("DMSWeight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.High)
                    .HasColumnName("HIGH")
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.IntegralCoefficient).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IntegralName).HasMaxLength(100);

                entity.Property(e => e.InventoryTurnover).HasMaxLength(50);

                entity.Property(e => e.IsAdproduct).HasColumnName("IsADProduct");

                entity.Property(e => e.IsCanDoVat).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsChange).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDistribution).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsGonlineShow).HasColumnName("IsGOnlineShow");

                entity.Property(e => e.IsInStock).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsInvoice).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPurchase).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPurchaseReturn).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsReturnGoods).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowTypeAll).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUnSaleable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IscreateSn).HasColumnName("ISCreateSN");

                entity.Property(e => e.Isinstall).HasColumnName("ISInstall");

                entity.Property(e => e.IslistShow)
                    .HasColumnName("ISListShow")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keywords).HasMaxLength(2000);

                entity.Property(e => e.Long)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.MaxOrderQuantity4).HasDefaultValueSql("((0))");

                entity.Property(e => e.MediaMerchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MerchandiseCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MsgTemplate).HasMaxLength(500);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OldProductId)
                    .HasColumnName("OldProductID")
                    .HasMaxLength(50);

                entity.Property(e => e.OnlineDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OnlineShowType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Opl).HasColumnName("OPL");

                entity.Property(e => e.OutStockFrequency)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageList).HasMaxLength(500);

                entity.Property(e => e.PackingList).HasMaxLength(255);

                entity.Property(e => e.Performance).HasColumnType("ntext");

                entity.Property(e => e.PictureStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.PmuserSysNo).HasColumnName("PMUserSysNo");

                entity.Property(e => e.PpmuserSysNo).HasColumnName("PPMUserSysNo");

                entity.Property(e => e.PreProductChannelShowType).HasMaxLength(20);

                entity.Property(e => e.PriceStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProducingArea).HasMaxLength(50);

                entity.Property(e => e.ProductChannelShowType).HasMaxLength(50);

                entity.Property(e => e.ProductDesc).HasMaxLength(2000);

                entity.Property(e => e.ProductDescLong).HasColumnType("ntext");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasColumnName("ProductID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductInventoryCycleTime).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductLink).HasMaxLength(200);

                entity.Property(e => e.ProductMode).HasMaxLength(100);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ProductNameStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.PromotionTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.PromotionTimeTo).HasColumnType("datetime");

                entity.Property(e => e.PromotionWord).HasMaxLength(500);

                entity.Property(e => e.SaleOverProduct).HasMaxLength(500);

                entity.Property(e => e.SaleStopProduct).HasMaxLength(500);

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Saleweekqty).HasColumnName("saleweekqty");

                entity.Property(e => e.Seodescription)
                    .HasColumnName("SEODescription")
                    .HasMaxLength(200);

                entity.Property(e => e.Seokeyword)
                    .HasColumnName("SEOKeyword")
                    .HasMaxLength(150);

                entity.Property(e => e.Seotitle)
                    .HasColumnName("SEOTitle")
                    .HasMaxLength(100);

                entity.Property(e => e.SoorderQuantity1).HasColumnName("SOOrderQuantity1");

                entity.Property(e => e.SoorderQuantity2).HasColumnName("SOOrderQuantity2");

                entity.Property(e => e.SoorderQuantity3).HasColumnName("SOOrderQuantity3");

                entity.Property(e => e.SoorderQuantity4)
                    .HasColumnName("SOOrderQuantity4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.TextDescription).HasMaxLength(2000);

                entity.Property(e => e.UnSaleableDesc).HasMaxLength(100);

                entity.Property(e => e.UpdateNewProductTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .IsRowVersion();

                entity.Property(e => e.Volume).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Warranty).HasMaxLength(200);

                entity.Property(e => e.WarrantyB2b)
                    .HasColumnName("WarrantyB2B")
                    .HasMaxLength(200);

                entity.Property(e => e.WarrantyB2g)
                    .HasColumnName("WarrantyB2G")
                    .HasMaxLength(200);

                entity.Property(e => e.WarrantyDescription).HasColumnType("ntext");

                entity.Property(e => e.WarrantyDescriptionB2b)
                    .HasColumnName("WarrantyDescriptionB2B")
                    .HasColumnType("ntext");

                entity.Property(e => e.WarrantyDescriptionB2g)
                    .HasColumnName("WarrantyDescriptionB2G")
                    .HasColumnType("ntext");

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.000000))");
            });

            modelBuilder.Entity<ProductAssociateItemTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_ASSOCIATE_ITEM");

                entity.ToTable("Product_Associate_Item_TD");

                entity.Property(e => e.PasysNo).HasColumnName("PASysNo");
            });

            modelBuilder.Entity<ProductAssociateMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_ASSOCIATE_MASTER");

                entity.ToTable("Product_Associate_Master_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.IsincluderSize).HasColumnName("ISIncluderSize");
            });

            modelBuilder.Entity<ProductAssociateSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Product_Associate_Sequence");

                entity.ToTable("Product_Associate_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProductAttribute2Summary>(entity =>
            {
                entity.HasKey(e => e.ProductSysNo);

                entity.ToTable("Product_Attribute2_Summary");

                entity.Property(e => e.ProductSysNo).ValueGeneratedNever();

                entity.Property(e => e.Summary).HasColumnType("ntext");

                entity.Property(e => e.SummaryMain).HasColumnType("ntext");

                entity.Property(e => e.SysNo).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ProductSysNoNavigation)
                    .WithOne(p => p.ProductAttribute2Summary)
                    .HasForeignKey<ProductAttribute2Summary>(d => d.ProductSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Attribute2_Summary_Product");
            });

            modelBuilder.Entity<ProductAttribute2Td>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Product_Attribute2");

                entity.ToTable("Product_Attribute2_TD");

                entity.HasIndex(e => e.Attribute2OptionSysNo)
                    .HasName("Ncl_Index_Attribute2OptionSysNo");

                entity.HasIndex(e => e.Attribute2SysNo)
                    .HasName("Ncl_Index_Attribute2SysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.Attribute2Value).HasMaxLength(2000);

                entity.Property(e => e.IsShow).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProductSysNoNavigation)
                    .WithMany(p => p.ProductAttribute2Td)
                    .HasForeignKey(d => d.ProductSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Attribute2_Product");
            });

            modelBuilder.Entity<ProductChannel>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_CHANNEL");

                entity.ToTable("Product_Channel");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.UpdateUserSysNo)
                    .HasName("Ncl_Index_UpdateUserSysNo");

                entity.HasIndex(e => new { e.ProductSysNo, e.ChanelType, e.ShowType })
                    .HasName("idx_Product_Channel_ChanelType_ShowType");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ProductSysNoNavigation)
                    .WithMany(p => p.ProductChannel)
                    .HasForeignKey(d => d.ProductSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT__REFERENCE_PRODUCT");
            });

            modelBuilder.Entity<ProductChannelSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Product_Channel_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProductCompetitorsPrice>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Product___EB33D9B10F670F02");

                entity.ToTable("Product_CompetitorsPrice");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Competitors).HasMaxLength(50);

                entity.Property(e => e.CompetitorsPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductCompetitorsPriceSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Product_CompetitorsPrice_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductCost>(entity =>
            {
                entity.HasKey(e => e.ProductSysNo);

                entity.ToTable("Product_Cost");

                entity.Property(e => e.ProductSysNo).ValueGeneratedNever();

                entity.Property(e => e.Amt).HasColumnType("numeric(19, 8)");

                entity.Property(e => e.Cost).HasColumnType("numeric(19, 8)");
            });

            modelBuilder.Entity<ProductId>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Product_ID");

                entity.HasIndex(e => e.ProductSysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Asnsysno).HasColumnName("ASNSysno");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PosysNo).HasColumnName("POSysNo");

                entity.Property(e => e.ProductSn)
                    .HasColumnName("ProductSN")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductTrackSn)
                    .HasColumnName("ProductTrackSN")
                    .HasMaxLength(50);

                entity.Property(e => e.ShelveTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockNo).HasMaxLength(20);
            });

            modelBuilder.Entity<ProductIdSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Product_ID_SEQUENCE");

                entity.ToTable("Product_ID_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProductListTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Product___EB33D9B177809FC6");

                entity.ToTable("Product_List_TD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ListAttribute).HasMaxLength(50);

                entity.Property(e => e.ListName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductMatch>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Product___EB33D9B173E77B11");

                entity.ToTable("Product_Match");
            });

            modelBuilder.Entity<ProductOnWayLog>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("ProductOnWay_Log");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.StockoutCause)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_PRICE");

                entity.ToTable("Product_Price");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => new { e.ProductSysNo, e.ChannelType })
                    .HasName("IDX_ProductSysNo_ChannelType");

                entity.HasIndex(e => new { e.ProductSysNo, e.CurrentPrice, e.ChannelType })
                    .HasName("Ncl_Index_ChannelType");

                entity.HasIndex(e => new { e.CurrentPrice, e.UnitCost, e.LastOrderPrice, e.ChannelType, e.SalesMultiple, e.ProductSysNo })
                    .HasName("ProductPrice_ProductSysNo");

                entity.HasIndex(e => new { e.SysNo, e.ProductSysNo, e.CurrentPrice, e.Point, e.SalesMultiple, e.PointPrice, e.ChannelType })
                    .HasName("idx_Product_Price_ChannelType");

                entity.HasIndex(e => new { e.SysNo, e.ProductSysNo, e.CurrentPrice, e.UnitCost, e.LastOrderPrice, e.SalesMultiple, e.ChannelType })
                    .HasName("ix_Product_Price_ChannelType");

                entity.Property(e => e.BasicPrice)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((999999))");

                entity.Property(e => e.CashRebate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ChannelType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClearanceSale).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostWithTax).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentPrice)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((999999))");

                entity.Property(e => e.CustomerType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastMarketLowestPrice)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastOrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.LimitedQty).HasDefaultValueSql("((999))");

                entity.Property(e => e.P1).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.P2).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.P3).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointType).HasDefaultValueSql("((2))");

                entity.Property(e => e.SalesMultiple).HasDefaultValueSql("((1))");

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ProductSysNoNavigation)
                    .WithMany(p => p.ProductPrice)
                    .HasForeignKey(d => d.ProductSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCTPRICE__REFERENCE_PRODUCT");
            });

            modelBuilder.Entity<ProductRelativeInfoTd>(entity =>
            {
                entity.HasKey(e => e.ProductSysNo)
                    .HasName("PK_PRODUCT_RELATIVEINFO");

                entity.ToTable("Product_RelativeInfo_TD");

                entity.Property(e => e.ProductSysNo).ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(500);

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShowType).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductSaleTrend>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_SALETREND");

                entity.ToTable("Product_SaleTrend");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Product_SaleTrend_ProductSysNo");

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.D3).HasColumnName("d3");

                entity.Property(e => e.D4).HasColumnName("d4");

                entity.Property(e => e.D5).HasColumnName("d5");

                entity.Property(e => e.D6).HasColumnName("d6");

                entity.Property(e => e.D7).HasColumnName("d7");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.M2).HasColumnName("m2");

                entity.Property(e => e.M3).HasColumnName("m3");

                entity.Property(e => e.M4).HasColumnName("m4");

                entity.Property(e => e.M5).HasColumnName("m5");

                entity.Property(e => e.M6).HasColumnName("m6");

                entity.Property(e => e.W1).HasColumnName("w1");

                entity.Property(e => e.W2).HasColumnName("w2");

                entity.Property(e => e.W3).HasColumnName("w3");

                entity.Property(e => e.W4).HasColumnName("w4");

                entity.Property(e => e.W5).HasColumnName("w5");

                entity.Property(e => e.W6).HasColumnName("w6");

                entity.Property(e => e.W7).HasColumnName("w7");
            });

            modelBuilder.Entity<ProductSaleTypeTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__ProductSaleType__32EB7E57");

                entity.ToTable("ProductSaleType_TD");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");
            });

            modelBuilder.Entity<ProductSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_SEQUENCE");

                entity.ToTable("Product_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductShipArea>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Product_ShipArea");

                entity.HasIndex(e => new { e.ShipAreaDesc, e.ProductSysNo })
                    .HasName("idx_Product_ShipArea_ProductSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ShipAreaDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductStatus>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_STATUS");

                entity.ToTable("Product_Status");

                entity.HasIndex(e => e.AllowUserSysNo)
                    .HasName("Ncl_Index_AllowUserSysNo");

                entity.HasIndex(e => e.InfoUserSysNo)
                    .HasName("Ncl_Index_InfoUserSysNo");

                entity.HasIndex(e => e.PicUserSysNo)
                    .HasName("Ncl_Index_PicUserSysNo");

                entity.HasIndex(e => e.PreviewUserSysNo)
                    .HasName("Ncl_Index_PreviewUserSysNo");

                entity.HasIndex(e => e.PriceUserSysNo)
                    .HasName("Ncl_Index_PriceUserSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Product_Status_ProductSysNo");

                entity.HasIndex(e => e.RmauserSysNo)
                    .HasName("Ncl_Index_RMAUserSysNo");

                entity.HasIndex(e => e.WarrantyUserSysNo)
                    .HasName("Ncl_Index_WarrantyUserSysNo");

                entity.HasIndex(e => e.WeightUserSysNo)
                    .HasName("Ncl_Index_WeightUserSysNo");

                entity.Property(e => e.AllowTime).HasColumnType("datetime");

                entity.Property(e => e.InfoTime).HasColumnType("datetime");

                entity.Property(e => e.PicTime).HasColumnType("datetime");

                entity.Property(e => e.PreviewStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.PreviewTime).HasColumnType("datetime");

                entity.Property(e => e.PreviewUserSysNo).HasDefaultValueSql("((33))");

                entity.Property(e => e.PriceTime).HasColumnType("datetime");

                entity.Property(e => e.Rmastatus)
                    .HasColumnName("RMAStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rmatime)
                    .HasColumnName("RMATime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RmauserSysNo).HasColumnName("RMAUserSysNo");

                entity.Property(e => e.WarrantyTime).HasColumnType("datetime");

                entity.Property(e => e.WeightTime).HasColumnType("datetime");

                entity.HasOne(d => d.ProductSysNoNavigation)
                    .WithMany(p => p.ProductStatus)
                    .HasForeignKey(d => d.ProductSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCTSTATUS__REFERENCE_PRODUCT");
            });

            modelBuilder.Entity<ProductStockStateTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__UnSaleab__EB33D9B15DFA9BF7");

                entity.ToTable("ProductStockState_TD");

                entity.HasIndex(e => new { e.IsUnSaleable, e.ProductSysNo, e.StockSysNo })
                    .HasName("IX_ProductStockState_SP");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductUpdateLog>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Product___EB33D9B150BBD860");

                entity.ToTable("Product_Update_Log");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LogType).HasMaxLength(10);
            });

            modelBuilder.Entity<ProductVendor>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PRODUCT_VENDOR");

                entity.ToTable("Product_Vendor");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.UpdateUserSysNo)
                    .HasName("Ncl_Index_UpdateUserSysNo");

                entity.HasIndex(e => e.VendorSysNo)
                    .HasName("Ncl_Index_VendorSysNo");

                entity.HasIndex(e => new { e.ProductSysNo, e.VendorSysNo, e.IsDefaultVendor })
                    .HasName("INDEX_Product_Vendor_IsDefaultVendor");

                entity.HasIndex(e => new { e.ProductSysNo, e.VendorSysNo, e.StockSysNo })
                    .HasName("Ncl_Index_StockSysNo");

                entity.HasIndex(e => new { e.ProductSysNo, e.PurchasePrice, e.MinOrderQty, e.VendorArrivalInternal, e.VendorSysNo, e.Status, e.StockSysNo })
                    .HasName("idx_Product_Vendor_VendorSysNo_Status_StockSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatetime)
                    .HasColumnName("lastUpdatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pounit)
                    .HasColumnName("POUnit")
                    .HasMaxLength(10);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.StockSysNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductWholeSaleSetTd>(entity =>
            {
                entity.HasKey(e => e.Sysno)
                    .HasName("PK__Product___EB32DDE95C979F60");

                entity.ToTable("Product_WholeSaleSet_TD");

                entity.Property(e => e.CanRevertPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDatetime).HasColumnType("datetime");

                entity.Property(e => e.LastPrice)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastupDatetime).HasColumnType("datetime");

                entity.Property(e => e.Maxprice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.WholeSaleBeginDate).HasColumnType("datetime");

                entity.Property(e => e.WholeSaleEndDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchasePlanTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_PURCHASEPLAN");

                entity.ToTable("PurchasePlan_TD");

                entity.Property(e => e.FirstSaleRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.GrowthRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.OrderRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SecondSaleRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ThirdSaleRate).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<QaTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_QA");

                entity.ToTable("QA_TD");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.Property(e => e.Answer).HasColumnType("text");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Question).HasMaxLength(500);

                entity.Property(e => e.SearchKey).HasMaxLength(500);
            });

            modelBuilder.Entity<RecommendProduct>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Recommen__EB33D9B14DC1D229");

                entity.Property(e => e.Brand).HasMaxLength(1000);

                entity.Property(e => e.C1sysNo).HasColumnName("C1SysNo");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.MaxRank).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MinRank).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<RecommendedBrand>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Recommen__EB33D9B17CD35D7B");

                entity.Property(e => e.BrandName).HasMaxLength(200);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHighlight).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Validity).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ReconciliationItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Reconcil__EB33D9B14F9D96F5");

                entity.ToTable("Reconciliation_Item");

                entity.HasIndex(e => e.MasterSysNo)
                    .HasName("Ncl_Index_MasterSysNo");

                entity.HasIndex(e => e.RefeSysNo)
                    .HasName("Ncl_Index_RefeSysNo");
            });

            modelBuilder.Entity<ReconciliationMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Reconcil__EB33D9B148F09966");

                entity.ToTable("Reconciliation_Master_TD");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.UpdateUserSysNo)
                    .HasName("Ncl_Index_UpdateUserSysNo");

                entity.HasIndex(e => new { e.CustomerGroupName, e.DepartmentName, e.ReconciliationMonth })
                    .HasName("Ncl_Index_Reconciliation_Master");

                entity.HasIndex(e => new { e.CustomerGroupName, e.DepartmentName, e.ReconciliationMonth, e.DepartmentCompanyName })
                    .HasName("Ncl_Index_Reconciliation_CustomerGroupName");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCompanyName).HasMaxLength(50);

                entity.Property(e => e.CustomerGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentCompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('尚未设置默认对账联系人')");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorMessage).HasMaxLength(100);

                entity.Property(e => e.ReconciliationMonth).HasDefaultValueSql("((201302))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WordName).HasMaxLength(100);
            });

            modelBuilder.Entity<ReviewBaseInfoTd>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PK__ReviewBa__74BC79CE19DA7BD4");

                entity.ToTable("ReviewBaseInfo_TD");

                entity.Property(e => e.ReviewId).ValueGeneratedNever();

                entity.Property(e => e.Content).HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.RankName).HasMaxLength(20);
            });

            modelBuilder.Entity<ReviewMasterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Review_Master");

                entity.ToTable("Review_Master_TD");

                entity.HasIndex(e => e.CreateCustomerSysNo)
                    .HasName("Ncl_Index_CreateCustomerSysNo");

                entity.HasIndex(e => e.LastEditUserSysNo)
                    .HasName("Ncl_Index_LastEditUserSysNo");

                entity.HasIndex(e => e.OperatorSysNo)
                    .HasName("Ncl_Index_OperatorSysNo");

                entity.HasIndex(e => e.ReferenceSysNo)
                    .HasName("Ncl_Index_ReferenceSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Browses).HasDefaultValueSql("((1))");

                entity.Property(e => e.Content1).HasMaxLength(1000);

                entity.Property(e => e.Content2).HasMaxLength(1000);

                entity.Property(e => e.Content3).HasMaxLength(1000);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerIp)
                    .HasColumnName("CustomerIP")
                    .HasMaxLength(30);

                entity.Property(e => e.Integral).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsaddScore).HasColumnName("ISAddScore");

                entity.Property(e => e.LastEditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Ordersysno).HasColumnName("ordersysno");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ReviewRemarkTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Review_Remark");

                entity.ToTable("Review_Remark_TD");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ReviewSysNoNavigation)
                    .WithMany(p => p.ReviewRemarkTd)
                    .HasForeignKey(d => d.ReviewSysNo)
                    .HasConstraintName("FK_Review_Remark_Review_Master");
            });

            modelBuilder.Entity<ReviewReplyTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Review_Reply");

                entity.ToTable("Review_Reply_TD");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastEditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReplyContent).HasMaxLength(1000);

                entity.HasOne(d => d.ReviewSysNoNavigation)
                    .WithMany(p => p.ReviewReplyTd)
                    .HasForeignKey(d => d.ReviewSysNo)
                    .HasConstraintName("FK_Review_Reply_Review_Master");
            });

            modelBuilder.Entity<ReviewSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Review_Sequence");

                entity.ToTable("Review_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ReviewStatisticTd>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__ReviewSt__727E838B1DAB0CB8");

                entity.ToTable("ReviewStatistic_TD");

                entity.Property(e => e.ItemId).ValueGeneratedNever();
            });

            modelBuilder.Entity<RmaHandlerDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentSysNo)
                    .HasName("PK__RMA_Hand__D501D7717711F932");

                entity.ToTable("RMA_HandlerDepartment");

                entity.Property(e => e.DepartmentSysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Order).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RmaItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RMA_ITEM");

                entity.ToTable("RMA_Item");

                entity.HasIndex(e => e.DoitemSysNo)
                    .HasName("Ncl_Index_DOItemSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.RmasysNo)
                    .HasName("Ncl_Index_RMASysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoitemSysNo).HasColumnName("DOItemSysNo");

                entity.Property(e => e.IsPkgFull).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rmadesc)
                    .HasColumnName("RMADesc")
                    .HasMaxLength(500);

                entity.Property(e => e.Rmaqty).HasColumnName("RMAQty");

                entity.Property(e => e.Rmareason)
                    .HasColumnName("RMAReason")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RmareportFileName)
                    .HasColumnName("RMAReportFileName")
                    .HasMaxLength(50);

                entity.Property(e => e.RmasysNo).HasColumnName("RMASysNo");

                entity.Property(e => e.Rmatype).HasColumnName("RMAType");

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RmasysNoNavigation)
                    .WithMany(p => p.RmaItem)
                    .HasForeignKey(d => d.RmasysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RMA_ITEM_REFERENCE_RMA_MAST");
            });

            modelBuilder.Entity<RmaMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RMA_MASTER");

                entity.ToTable("RMA_Master");

                entity.HasIndex(e => e.CloseUserSysNo)
                    .HasName("Ncl_Index_CloseUserSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.DosysNo)
                    .HasName("Ncl_Index_DOSysNo");

                entity.HasIndex(e => e.LastUserSysNo)
                    .HasName("Ncl_Index_LastUserSysNo");

                entity.HasIndex(e => e.PickUpAreaSysNo)
                    .HasName("Ncl_Index_PickUpAreaSysNo");

                entity.HasIndex(e => e.ReceiveAreaSysNo)
                    .HasName("Ncl_Index_ReceiveAreaSysNo");

                entity.HasIndex(e => e.ShipTypeSysNo)
                    .HasName("Ncl_Index_ShipTypeSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.HasIndex(e => new { e.DosysNo, e.SysNo, e.Status })
                    .HasName("idx_RMA_Master_Status");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.Ccnote)
                    .HasColumnName("CCNote")
                    .HasMaxLength(500);

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCompanyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DosysNo)
                    .HasColumnName("DOSysNo")
                    .HasDefaultValueSql("((-999999))");

                entity.Property(e => e.DutyDepartment)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ExpenseDepartment)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FollowupDepartment).HasDefaultValueSql("((-999999))");

                entity.Property(e => e.IsSdsysNo)
                    .HasColumnName("IsSDSysNo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PickUpAddress).HasMaxLength(200);

                entity.Property(e => e.PickUpContact).HasMaxLength(100);

                entity.Property(e => e.PickUpMobile).HasMaxLength(20);

                entity.Property(e => e.PickUpPhone).HasMaxLength(100);

                entity.Property(e => e.PickUpTime).HasColumnType("datetime");

                entity.Property(e => e.PickUpZip).HasMaxLength(20);

                entity.Property(e => e.PointShipPrice).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveInfo).HasColumnType("ntext");

                entity.Property(e => e.ReceiveName).HasMaxLength(100);

                entity.Property(e => e.ReceivePhone).HasMaxLength(20);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiveZip).HasMaxLength(20);

                entity.Property(e => e.RefundAccount).HasMaxLength(100);

                entity.Property(e => e.RefundAccountName).HasMaxLength(50);

                entity.Property(e => e.RefundBank).HasMaxLength(100);

                entity.Property(e => e.Rmaid)
                    .IsRequired()
                    .HasColumnName("RMAID")
                    .HasMaxLength(20);

                entity.Property(e => e.Rmanote)
                    .HasColumnName("RMANote")
                    .HasColumnType("text");

                entity.Property(e => e.Rmatime)
                    .HasColumnName("RMATime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RmauserSysNo).HasColumnName("RMAUserSysNo");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.SubmitInfo).HasColumnType("ntext");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserChangedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RmaRegisterSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RMA_Register_Sequence");

                entity.ToTable("RMA_Register_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RmaRegisterTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RMA_Register");

                entity.ToTable("RMA_Register_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AttachmentInfo).HasMaxLength(500);

                entity.Property(e => e.CheckDesc).HasMaxLength(500);

                entity.Property(e => e.CheckRepairNote).HasMaxLength(500);

                entity.Property(e => e.CheckRepairTime).HasColumnType("datetime");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.Cost).HasColumnType("decimal(16, 9)");

                entity.Property(e => e.CustomerDesc).HasMaxLength(500);

                entity.Property(e => e.InspectionResultType).HasMaxLength(100);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.NewProductIdsysNo).HasColumnName("NewProductIDSysNo");

                entity.Property(e => e.PmdunDesc)
                    .HasColumnName("PMDunDesc")
                    .HasMaxLength(1000);

                entity.Property(e => e.PmdunTime)
                    .HasColumnName("PMDunTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductIdsysNo).HasColumnName("ProductIDSysNo");

                entity.Property(e => e.ProductNo).HasMaxLength(50);

                entity.Property(e => e.RefundAuditMemo).HasMaxLength(100);

                entity.Property(e => e.RefundAuditTime).HasColumnType("datetime");

                entity.Property(e => e.RefundInfo).HasMaxLength(200);

                entity.Property(e => e.ResponseDesc).HasMaxLength(200);

                entity.Property(e => e.ResponseProductNo).HasMaxLength(50);

                entity.Property(e => e.ResponseTime).HasColumnType("datetime");

                entity.Property(e => e.RevertAuditTime).HasColumnType("datetime");

                entity.Property(e => e.Rmareason).HasColumnName("RMAReason");

                entity.Property(e => e.SetShiftTime).HasColumnType("datetime");

                entity.Property(e => e.VendorRepairResultType).HasMaxLength(100);
            });

            modelBuilder.Entity<RmaSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RMA_SEQUENCE");

                entity.ToTable("RMA_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RmaShiftTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RMA_Shift");

                entity.ToTable("RMA_Shift_TD");

                entity.Property(e => e.RmashiftType).HasColumnName("RMAShiftType");
            });

            modelBuilder.Entity<RoExchange>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RO_EXCHANGE");

                entity.ToTable("RO_Exchange");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerDepartmentComparyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeId)
                    .IsRequired()
                    .HasColumnName("ExchangeID")
                    .HasMaxLength(50);

                entity.Property(e => e.OutTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoExchangeItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RO_EXCHANGE_ITEM");

                entity.ToTable("RO_Exchange_Item");

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 8)");
            });

            modelBuilder.Entity<RoItem>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("RO_Item");

                entity.HasIndex(e => e.DoitemSysNo)
                    .HasName("Ncl_Index_DOItemSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.RosysNo)
                    .HasName("Ncl_Index_ROSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoitemSysNo)
                    .HasColumnName("DOItemSysNo")
                    .HasDefaultValueSql("((-999999))");

                entity.Property(e => e.GiftCardPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Modal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RedeemAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RefundBalance).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RefundCash)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefundPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.RosysNo).HasColumnName("ROSysNo");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UnitUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");

                entity.HasOne(d => d.RosysNoNavigation)
                    .WithMany(p => p.RoItem)
                    .HasForeignKey(d => d.RosysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RO_ITEM_REFERENCE_RO_MASTE");
            });

            modelBuilder.Entity<RoItemReturn>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("RO_Item_Return");

                entity.HasIndex(e => e.ReturnProductSysNo)
                    .HasName("Ncl_Index_ReturnProductSysNo");

                entity.HasIndex(e => e.RoitemSysNo)
                    .HasName("Ncl_Index_ROItemSysNo");

                entity.HasIndex(e => e.RosysNo)
                    .HasName("Ncl_Index_ROSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoitemSysNo).HasColumnName("ROItemSysNo");

                entity.Property(e => e.RosysNo).HasColumnName("ROSysNo");
            });

            modelBuilder.Entity<RoItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RO_Item_SEQUENCE");

                entity.ToTable("RO_Item_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RoMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RO_MASTER");

                entity.ToTable("RO_Master");

                entity.HasIndex(e => e.DosysNo)
                    .HasName("Ncl_Index_DOSysNo");

                entity.HasIndex(e => e.PickUpAreaSysNo)
                    .HasName("Ncl_Index_PickUpAreaSysNo");

                entity.HasIndex(e => e.ReceiveAreaSysNo)
                    .HasName("Ncl_Index_ReceiveAreaSysNo");

                entity.HasIndex(e => e.RmasysNo)
                    .HasName("Ncl_Index_RMASysNo");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.HasIndex(e => new { e.Roid, e.ReturnTime, e.IsReconciliation, e.Status })
                    .HasName("ix_ro_master_001");

                entity.HasIndex(e => new { e.EndAmt, e.BranchSysNo, e.CashAmt, e.AuditTime, e.ReturnTime, e.IsReconciliation, e.VerificationTime, e.IsSdsysNo, e.SysNo, e.Roid, e.RmasysNo, e.Status, e.OriginCashAmt, e.ProductSaleType, e.CreateTime })
                    .HasName("idx_RO_Master_ProductSaleType_CreateTime");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.CashAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCompanyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DosysNo)
                    .HasColumnName("DOSysNo")
                    .HasDefaultValueSql("((-999999))");

                entity.Property(e => e.EndAmt)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeSo).HasColumnName("ExchangeSO");

                entity.Property(e => e.InvoiceStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.IsHaveInvoice).HasColumnName("isHaveInvoice");

                entity.Property(e => e.IsSdsysNo)
                    .HasColumnName("IsSDSysNo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isexchange)
                    .HasColumnName("ISExchange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LatestCollectionTime).HasColumnType("datetime");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Omsroid)
                    .HasColumnName("OMSROID")
                    .HasMaxLength(50);

                entity.Property(e => e.OriginCashAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PickUpAddress).HasMaxLength(200);

                entity.Property(e => e.PickUpContact).HasMaxLength(100);

                entity.Property(e => e.PickUpMobile).HasMaxLength(20);

                entity.Property(e => e.PickUpPhone).HasMaxLength(100);

                entity.Property(e => e.PickUpTime).HasColumnType("datetime");

                entity.Property(e => e.PickUpZip).HasMaxLength(20);

                entity.Property(e => e.PointShipPrice).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveName).HasMaxLength(100);

                entity.Property(e => e.ReceivePhone).HasMaxLength(20);

                entity.Property(e => e.ReceiveZip).HasMaxLength(20);

                entity.Property(e => e.RedeemAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RefundApproveTime).HasColumnType("datetime");

                entity.Property(e => e.RefundBalance).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RefundGiftCard).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RefundTime).HasColumnType("datetime");

                entity.Property(e => e.RequestRefundTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.RmasysNo).HasColumnName("RMASysNo");

                entity.Property(e => e.Roid)
                    .IsRequired()
                    .HasColumnName("ROID")
                    .HasMaxLength(20);

                entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.TotalUsePoints).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoRefund>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("RO_Refund");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.RefundId)
                    .HasColumnName("RefundID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefundLog).HasMaxLength(4000);

                entity.Property(e => e.RefundMoney).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RefundReason).HasMaxLength(20);

                entity.Property(e => e.RefundStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RosysNo).HasColumnName("ROSysNo");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.TradeNo).HasMaxLength(50);
            });

            modelBuilder.Entity<RoSaleRuleItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RO_SALERULE_ITEM");

                entity.ToTable("RO_SaleRule_Item");

                entity.HasIndex(e => e.RosysNo)
                    .HasName("Ncl_Index_ROSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.HasIndex(e => e.SrsysNo)
                    .HasName("Ncl_Index_SRSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RosysNo).HasColumnName("ROSysNo");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.SrsysNo).HasColumnName("SRSysNo");
            });

            modelBuilder.Entity<RoSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_RO_SEQUENCE");

                entity.ToTable("RO_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaleCountdownNewSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sale_CountdownNew_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleCountdownNewTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Sale_CountdownNew");

                entity.ToTable("Sale_CountdownNew_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.Cdprice)
                    .HasColumnName("CDPrice")
                    .HasColumnType("decimal(16, 9)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Cdqty).HasColumnName("CDQty");

                entity.Property(e => e.ChanelType).HasDefaultValueSql("((1))");

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.CountDownDescription).HasMaxLength(500);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerRankCom).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InterruptTime).HasColumnType("datetime");

                entity.Property(e => e.IsEmailNotice).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMessageboxNotice).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ResumeTime).HasColumnType("datetime");

                entity.Property(e => e.SaleQtyCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalePointDelayTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SALE_POINTDELAY");

                entity.ToTable("Sale_PointDelay_TD");

                entity.HasIndex(e => e.DosysNo)
                    .HasName("Ncl_Index_DOSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DosysNo)
                    .HasColumnName("DOSysNo")
                    .HasDefaultValueSql("((-999999))");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<SaleRuleItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SALERULE_ITEM");

                entity.ToTable("SaleRule_Item");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.SaleRuleSysNo)
                    .HasName("Ncl_Index_SaleRuleSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsIconLoad).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SaleRuleMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("SaleRule_Master");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsPromotionInfoShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.PromotionLink).HasMaxLength(200);

                entity.Property(e => e.PromotionWrods).HasMaxLength(200);

                entity.Property(e => e.SaleRuleName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.WebPromotionTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<SaleRuleMasterSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SaleRule_Master_SEQUENCE");

                entity.ToTable("SaleRule_Master_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaleUnitMap>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__SaleUnit__EB33D9B1706CBB3F");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.InterfaceCode).HasMaxLength(50);

                entity.Property(e => e.InterfaceUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysUnit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaleUnitOriTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SaleUnit");

                entity.ToTable("SaleUnit_ORI_TD");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesInvoiceGroupEtl>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sales_Invoice_Group_ETL");

                entity.HasIndex(e => new { e.SysNo, e.CompanyName, e.BranchSysNo })
                    .HasName("idx_Sales_Invoice_Group_ETL_BranchSysNo");

                entity.HasIndex(e => new { e.SysNo, e.CustomerGroup, e.BranchSysNo })
                    .HasName("IX_Sales_Invoice_Group_ETL_BranckSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BankInfo).HasMaxLength(50);

                entity.Property(e => e.CompanyAddress).HasMaxLength(200);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerGroup).HasMaxLength(20);

                entity.Property(e => e.CustomerInvoiceRemark).HasMaxLength(500);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmt).HasColumnType("numeric(19, 8)");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceReceiver)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ProductInvoiceType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxNum).HasMaxLength(50);

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesInvoiceGroupItemEtl>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sales_Invoice_Group_Item_ETL");

                entity.HasIndex(e => new { e.ReferSysNo, e.GroupSysNo, e.Type })
                    .HasName("IX_Sales_Invoice_Group_Item_ETL_Type");

                entity.HasIndex(e => new { e.GroupSysNo, e.ReferSysNo, e.Type, e.Status })
                    .HasName("idx_Sales_Invoice_Group_Item_ETL_Type_Status");

                entity.Property(e => e.SysNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<SalesInvoiceGroupItemRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SALES_INVOICE_GROUP_ITEM");

                entity.ToTable("Sales_Invoice_Group_Item_REF");

                entity.HasIndex(e => new { e.GroupSysNo, e.ReferSysNo, e.Type })
                    .HasName("idx_Sales_Invoice_Group_Item_Type");

                entity.HasIndex(e => new { e.ReferSysNo, e.Type, e.Status })
                    .HasName("idx_Sales_Invoice_Group_Item_Type_Status");

                entity.HasIndex(e => new { e.Type, e.GroupSysNo, e.ReferSysNo })
                    .HasName("ix_Sales_Invoice_Group_Item_1");
            });

            modelBuilder.Entity<SalesInvoiceGroupRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SALES_INVOICE_GROUP");

                entity.ToTable("Sales_Invoice_Group_REF");

                entity.HasIndex(e => new { e.SysNo, e.CreateTime })
                    .HasName("Ncl_Index_Sales_Invoice_Group_CreateTime");

                entity.HasIndex(e => new { e.CompanyName, e.IsMerge, e.DepartmentName, e.CustomerGroup })
                    .HasName("Ncl_Index_Sales_Invoice_Group");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.BankInfo).HasMaxLength(100);

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.CompanyAddress).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerGroup).HasMaxLength(50);

                entity.Property(e => e.CustomerInvoiceRemark).HasMaxLength(500);

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.InvoiceAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(4000);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.InvoiceReceiver)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'仓库')");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ProductInvoiceType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('默认明细')");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.TaxNum).HasMaxLength(20);

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesInvoiceGroupSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SALES_INVOICE_GROUP_SEQUENC");

                entity.ToTable("Sales_Invoice_Group_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesInvoiceImport>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SALES_INVOICE_IMPORT");

                entity.ToTable("Sales_Invoice_Import");

                entity.HasIndex(e => e.GroupSysNo)
                    .HasName("index_Sales_Invoice_Import_GroupSysNo");

                entity.Property(e => e.AmountOfTax).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BankName).HasMaxLength(200);

                entity.Property(e => e.CustomerAddress).HasMaxLength(200);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerNo).HasMaxLength(200);

                entity.Property(e => e.CustomerTax).HasMaxLength(200);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DiscountTaxAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Drawer).HasMaxLength(20);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IssueDate).HasMaxLength(20);

                entity.Property(e => e.Payee).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProdcutId).HasMaxLength(20);

                entity.Property(e => e.ProductMode).HasMaxLength(200);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(400);

                entity.Property(e => e.Reviewer).HasMaxLength(20);

                entity.Property(e => e.SalesAddress).HasMaxLength(200);

                entity.Property(e => e.SalesBankAccountNumber).HasMaxLength(200);

                entity.Property(e => e.Sign)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Tax).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SalesInvoiceOffice>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sales_Invoice_Office");

                entity.Property(e => e.AbandonTime).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DosysNo).HasColumnName("DOSysNo");
            });

            modelBuilder.Entity<SearchKeyRecommendTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SearchKeyRecommend");

                entity.ToTable("SearchKeyRecommend_TD");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ShipTypeAreaConfigTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ShipType_Area_Config1");

                entity.ToTable("ShipType_Area_Config_TT");

                entity.Property(e => e.ShipTypeDesc)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ShipTypeAreaPrice>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SHIPTYPE_AREA_PRICE");

                entity.ToTable("ShipType_Area_Price");

                entity.HasIndex(e => e.AreaSysNo)
                    .HasName("Ncl_Index_AreaSysNo");

                entity.HasIndex(e => e.ShipTypeSysNo)
                    .HasName("Ncl_Index_ShipTypeSysNo");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<ShipTypeAreaUnEtl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__ShipType__EB33D9B1D3F4B267");

                entity.ToTable("ShipType_Area_Un_ETL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ShipTypeAreaUnRefTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SHIPTYPE_AREA_UN");

                entity.ToTable("ShipType_Area_Un_REF_TD");
            });

            modelBuilder.Entity<ShipTypeExtend>(entity =>
            {
                entity.HasKey(e => e.ShipTypeSysNo)
                    .HasName("PK__ShipType__69C0723F146264F7");

                entity.Property(e => e.ShipTypeSysNo).ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.Extend1).HasMaxLength(100);

                entity.Property(e => e.Extend2).HasMaxLength(100);

                entity.Property(e => e.Extend3).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.IdentityFlag)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsRunning)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.Province).HasMaxLength(20);

                entity.Property(e => e.ReceiveAddress).HasMaxLength(100);

                entity.Property(e => e.ReceiveCity).HasMaxLength(20);

                entity.Property(e => e.ReceiveDistrict).HasMaxLength(50);

                entity.Property(e => e.ReceiveProvince).HasMaxLength(20);

                entity.Property(e => e.ReciverLoanAccount).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);
            });

            modelBuilder.Entity<ShipTypeHousePurchaseTt>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__ShipType__EB33D9B1585CFA28");

                entity.ToTable("ShipType_HousePurchase_TT");

                entity.Property(e => e.ShipDescription).HasMaxLength(500);
            });

            modelBuilder.Entity<ShipTypePayTypeUnEtl>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__ShipType__EB33D9B1F9199439");

                entity.ToTable("ShipType_PayType_Un_ETL");

                entity.Property(e => e.SysNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ShipTypePayTypeUnRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SHIPTYPE_PAYTYPE_UN");

                entity.ToTable("ShipType_PayType_Un_REF");
            });

            modelBuilder.Entity<ShipTypeRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SHIPTYPE");

                entity.ToTable("ShipType_REF");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ExpressGradeService).HasDefaultValueSql("((1))");

                entity.Property(e => e.FreeShipBase).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsSynTms)
                    .HasColumnName("IsSynTMS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWithPackFee).HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PickUpAddress).HasMaxLength(200);

                entity.Property(e => e.PremiumBase).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PremiumRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShipTypeBk)
                    .HasColumnName("ShipTypeBK")
                    .HasMaxLength(200);

                entity.Property(e => e.ShipTypeDesc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ShipTypeId)
                    .IsRequired()
                    .HasColumnName("ShipTypeID")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusQueryUrl).HasMaxLength(500);
            });

            modelBuilder.Entity<ShipTypeSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SHIPTYPE_SEQUENCE");

                entity.ToTable("ShipType_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShowCategoryC3Td>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__ShowCate__EB33D9B142501F7D");

                entity.ToTable("ShowCategoryC3_TD");

                entity.Property(e => e.C1sysNo).HasColumnName("C1SysNo");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");
            });

            modelBuilder.Entity<ShowCategoryTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__ShowCate__EB33D9B13E7F8E99");

                entity.ToTable("ShowCategory_TD");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(256);

                entity.Property(e => e.ShowCategoryName).HasMaxLength(200);
            });

            modelBuilder.Entity<Size1>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Size1Id)
                    .HasColumnName("Size1ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Size1Name).HasMaxLength(50);

                entity.Property(e => e.Size1Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Size2>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Size2Id)
                    .HasColumnName("Size2ID")
                    .HasMaxLength(20);

                entity.Property(e => e.Size2Img).HasMaxLength(500);

                entity.Property(e => e.Size2Name).HasMaxLength(50);

                entity.HasOne(d => d.Size1SysNoNavigation)
                    .WithMany(p => p.Size2)
                    .HasForeignKey(d => d.Size1SysNo)
                    .HasConstraintName("FK_Size2_Size1");
            });

            modelBuilder.Entity<SoAlipay>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("SO_Alipay");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("uq_SOAlipay_SOSysNo")
                    .IsUnique();

                entity.Property(e => e.AlipayTradeNo).HasMaxLength(50);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<SoGiftActivity>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_GIFTACTIVITY");

                entity.ToTable("SO_GiftActivity");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.HasIndex(e => new { e.SosysNo, e.GiftActivitySysNo, e.Type })
                    .HasName("idx_SO_GiftActivity_Type");

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(16, 9)");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.OrginalPrice).HasColumnType("decimal(16, 9)");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.16))");

                entity.Property(e => e.TotalPoints)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalUsePoints)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPoints)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitUsePoints)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SoInvoiceLog>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__SO_Invoi__EB33D9B159544BBD");

                entity.ToTable("SO_InvoiceLog");

                entity.HasIndex(e => e.SoSysNo)
                    .HasName("idx_SO_InvoiceLog_SoSysNo");

                entity.Property(e => e.Cash).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NeverShipAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShipAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Soamt)
                    .HasColumnName("SOAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Soid)
                    .IsRequired()
                    .HasColumnName("SOID")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SoItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_ITEM")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SO_Item");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("IX_SO_Item")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.SosysNo, e.ProductSysNo, e.Price })
                    .HasName("ix_SO_Item_001");

                entity.HasIndex(e => new { e.OutStockQty, e.SosysNo, e.Quantity, e.WaitOutQty, e.ProductSysNo, e.IsInStock })
                    .HasName("idx_SO_Item_ProductSysNo_IsInStock");

                entity.HasIndex(e => new { e.WaitOutQty, e.OutStockQty, e.SosysNo, e.Quantity, e.ProductSysNo, e.IsInStock, e.IsMarkUnOutStock })
                    .HasName("idx_SO_Item_ProductSysNo_IsInStock_IsMarkUnOutStock");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BaseProductType).HasDefaultValueSql("((0))");

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CdsysNo).HasColumnName("CDSysNo");

                entity.Property(e => e.ContractDescription).HasMaxLength(200);

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponAmtApportion).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponAmtApportionForPm)
                    .HasColumnName("CouponAmtApportionForPM")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsAgreementProduct).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCanVat).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsContractProduct).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMarkUnOutStock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isinstall).HasColumnName("ISInstall");

                entity.Property(e => e.IsvirtualStock).HasColumnName("ISVirtualStock");

                entity.Property(e => e.ItemSkuCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Modal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.NetPrice).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointType).HasDefaultValueSql("((2))");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('无')");

                entity.Property(e => e.ProductNote).HasMaxLength(4000);

                entity.Property(e => e.RealPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SaleUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.TotalPoints)
                    .HasColumnType("decimal(19, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalUsePoints)
                    .HasColumnType("decimal(19, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPoints)
                    .HasColumnType("decimal(19, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitUsePoints)
                    .HasColumnType("decimal(19, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Volume).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Warranty).HasMaxLength(500);

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 6)");

                entity.HasOne(d => d.SosysNoNavigation)
                    .WithMany(p => p.SoItem)
                    .HasForeignKey(d => d.SosysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SO_ITEM_REFERENCE_SO_MASTE");
            });

            modelBuilder.Entity<SoItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_Item_SEQUENCE");

                entity.ToTable("SO_Item_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SoItemUpdateHistory>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_ITEM_UpdateHistory")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SO_Item_UpdateHistory");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("idx_SO_Item_UpdateHistory_SOSysNo");

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

            modelBuilder.Entity<SoMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_MASTER");

                entity.ToTable("SO_Master");

                entity.HasIndex(e => e.ChannelSoid)
                    .HasName("SO_Master_ChannelSOID");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.ManagerAuditUserSysNo)
                    .HasName("Ncl_Index_ManagerAuditUserSysNo");

                entity.HasIndex(e => e.OperatorSysNo)
                    .HasName("Ncl_Index_OperatorSysNo");

                entity.HasIndex(e => e.ReceiveAreaSysNo)
                    .HasName("Ncl_Index_ReceiveAreaSysNo");

                entity.HasIndex(e => e.ReceiveZip)
                    .HasName("_dta_stat_953770455_31");

                entity.HasIndex(e => e.SalesManSysNo)
                    .HasName("Ncl_Index_SalesManSysNo");

                entity.HasIndex(e => e.ShipPriceDosysNo)
                    .HasName("Ncl_Index_ShipPriceDOSysNo");

                entity.HasIndex(e => e.ShipTypeSysNo)
                    .HasName("Ncl_Index_ShipTypeSysNo");

                entity.HasIndex(e => e.Soid)
                    .HasName("Ncl_Index_SOID");

                entity.HasIndex(e => e.SourceId)
                    .HasName("Ncl_Index_SourceId");

                entity.HasIndex(e => new { e.SysNo, e.Soid })
                    .HasName("SO_Master_Index_1");

                entity.HasIndex(e => new { e.Soid, e.CustomerDepartmentSysNo, e.IsOfflineShow })
                    .HasName("idx_SO_Master_CustomerDepartmentSysNo_IsOfflineShow");

                entity.HasIndex(e => new { e.SysNo, e.PayTypeSysNo, e.OperatorSysNo })
                    .HasName("ix_SO_Master_SPO");

                entity.HasIndex(e => new { e.SysNo, e.Status, e.WaitAduitOperatorSysNo })
                    .HasName("idx_SO_Master_Status_WaitAduitOperatorSysNo");

                entity.HasIndex(e => new { e.SysNo, e.DefaultStockSysNo, e.Status, e.OutStockStatus })
                    .HasName("Ncl_Index_DefaultStockSysNo");

                entity.HasIndex(e => new { e.SysNo, e.Soid, e.CustomerDepartmentSysNo, e.IsOfflineShow })
                    .HasName("idx_SO_Master_IsOfflineShow");

                entity.HasIndex(e => new { e.SysNo, e.Soid, e.CustomerSysNo, e.PayTypeSysNo })
                    .HasName("SO_Master_PayTypeSysNo");

                entity.HasIndex(e => new { e.SysNo, e.CustomerSysNo, e.ChannelSoid, e.ProductSaleType, e.Status })
                    .HasName("idx_SO_Master_ProductSaleType_Status");

                entity.HasIndex(e => new { e.CustomerSysNo, e.ReceiveContact, e.SysNo, e.ProductSaleType, e.Status, e.OrderDate })
                    .HasName("idx_SO_Master_ProductSaleType_Status_OrderDate_INCLUDE");

                entity.HasIndex(e => new { e.PayTypeSysNo, e.ShipTypeSysNo, e.ReceiveAreaSysNo, e.SalesManSysNo, e.CustomerSysNo, e.OrderDate, e.ProductSaleType, e.Status })
                    .HasName("IX_SO_Master_20161011");

                entity.HasIndex(e => new { e.SysNo, e.Soid, e.CustomerSysNo, e.SalesManSysNo, e.PointShipPrice, e.TotalPoints, e.TotalUsePoints, e.IsThePlan, e.SourceId, e.IsHold, e.CustomerOnLock, e.CustomerOnLockTime, e.ChannelSoid, e.AuditUserSysNo, e.AuditTime, e.OutTime, e.HasExpectQty, e.Sosource, e.OutStockStatus, e.ReceiveContact, e.ReceivePhone, e.ReceiveCellPhone, e.AllocatedManSysNo, e.UpdateUserSysNo, e.UpdateTime, e.DiscountAmt, e.CouponAmt, e.PointAmt, e.CashPay, e.PointPay, e.ReceiveAreaSysNo, e.PremiumAmt, e.ShipTypeSysNo, e.ShipPrice, e.FreeShipFeePay, e.PayTypeSysNo, e.PayPrice, e.ProductSaleType, e.SaleManSysNo, e.Status, e.OrderDate })
                    .HasName("Ncl_Index_SaleManSysNo_ProductSaleType");

                entity.HasIndex(e => new { e.CustomerOnLockTime, e.ChannelSoid, e.PointShipPrice, e.TotalPoints, e.TotalUsePoints, e.HoldCustomerSysNo, e.HasExpectQty, e.Sosource, e.OutStockStatus, e.IsThePlan, e.IsHold, e.CustomerOnLock, e.UpdateUserSysNo, e.UpdateTime, e.AuditUserSysNo, e.AuditTime, e.OutTime, e.DeliveryMemo, e.CashPay, e.PointPay, e.ReceiveAreaSysNo, e.ReceiveContact, e.ReceivePhone, e.AllocatedManSysNo, e.FreeShipFeePay, e.PayTypeSysNo, e.PayPrice, e.DiscountAmt, e.CouponAmt, e.PointAmt, e.OrderDate, e.SalesManSysNo, e.IsWholeSale, e.PremiumAmt, e.ShipTypeSysNo, e.ShipPrice, e.HoldTime, e.BranchSysNo, e.SysNo, e.Soid, e.CustomerSysNo, e.ReceiveCellPhone, e.ProductSaleType, e.Status })
                    .HasName("idx_SO_Master_ReceiveCellPhone_ProductSaleType_Status");

                entity.HasIndex(e => new { e.SysNo, e.Soid, e.CustomerSysNo, e.SalesManSysNo, e.ChannelSoid, e.PointShipPrice, e.TotalPoints, e.TotalUsePoints, e.HoldCustomerSysNo, e.HoldTime, e.Sosource, e.OutStockStatus, e.IsThePlan, e.IsHold, e.CustomerOnLock, e.CustomerOnLockTime, e.UpdateTime, e.AuditUserSysNo, e.AuditTime, e.OutTime, e.DeliveryMemo, e.HasExpectQty, e.ReceiveAreaSysNo, e.ReceiveContact, e.ReceivePhone, e.ReceiveCellPhone, e.AllocatedManSysNo, e.UpdateUserSysNo, e.PayPrice, e.DiscountAmt, e.CouponAmt, e.PointAmt, e.CashPay, e.PointPay, e.IsWholeSale, e.PremiumAmt, e.ShipTypeSysNo, e.ShipPrice, e.FreeShipFeePay, e.PayTypeSysNo, e.ProductSaleType, e.ReasonNotAudit, e.Status, e.OrderDate })
                    .HasName("idx_SO_Master_ProductSaleType_ReasonNotAudit_Status_OrderDate");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.AuditDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BalancePayAmt)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BdcustomerClassId1).HasColumnName("BDCustomerClassId1");

                entity.Property(e => e.BdcustomerClassId2).HasColumnName("BDCustomerClassId2");

                entity.Property(e => e.BdcustomerClassId3).HasColumnName("BDCustomerClassId3");

                entity.Property(e => e.BdenterpriseTypeSysNo).HasColumnName("BDEnterpriseTypeSysNo");

                entity.Property(e => e.BdsaleManSysNo).HasColumnName("BDSaleManSysNo");

                entity.Property(e => e.BranchSysNo).HasDefaultValueSql("((11))");

                entity.Property(e => e.CashPay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ChannelSoid)
                    .HasColumnName("ChannelSOID")
                    .HasMaxLength(100);

                entity.Property(e => e.CheckQtyTime).HasColumnType("datetime");

                entity.Property(e => e.CloseMsg).HasMaxLength(255);

                entity.Property(e => e.CmuserSysNo).HasColumnName("CMUserSysNo");

                entity.Property(e => e.CouponAmt)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponCode).HasMaxLength(50);

                entity.Property(e => e.CouponReturnRosysNo).HasColumnName("CouponReturnROSysNo");

                entity.Property(e => e.CouponType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CsuserSysNo).HasColumnName("CSUserSysNo");

                entity.Property(e => e.CustomerManSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerOnLockTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerVatInfoId).HasColumnName("CustomerVatInfoID");

                entity.Property(e => e.DeliveryBillFileName).HasMaxLength(100);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMemo).HasMaxLength(200);

                entity.Property(e => e.DepartmentCompanyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('  ')");

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DistributionCode).HasMaxLength(200);

                entity.Property(e => e.DistributionRequireType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DlsysNo).HasColumnName("DLSysNo");

                entity.Property(e => e.ExpectAuditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpectDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Exportlist)
                    .HasColumnName("EXPORTLIST")
                    .HasMaxLength(2000);

                entity.Property(e => e.FreeShipFeePay)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiftCardPay)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasExpectQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasServiceProduct).HasDefaultValueSql("((0))");

                entity.Property(e => e.HoldTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNote).HasMaxLength(500);

                entity.Property(e => e.InvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.IsAttachDeliveryBill).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAutoCalcDeliveryDate).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAutoCalcShipPrice).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMergeSo).HasColumnName("IsMergeSO");

                entity.Property(e => e.IsOfflineShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendInvoice).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUploadDeliveryBill).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.OperatorAddressId)
                    .HasColumnName("OperatorAddressID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PayPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PointShipPrice)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosFee).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.PremiumAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ProductInvoiceType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('默认明细')");

                entity.Property(e => e.RealSoamt)
                    .HasColumnName("RealSOAmt")
                    .HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReceiveAddress).HasMaxLength(200);

                entity.Property(e => e.ReceiveCellPhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveContact).HasMaxLength(100);

                entity.Property(e => e.ReceiveEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiveName).HasMaxLength(100);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivePhone).HasMaxLength(100);

                entity.Property(e => e.ReceiveZip).HasMaxLength(20);

                entity.Property(e => e.RequestInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnCoupons).HasMaxLength(2000);

                entity.Property(e => e.SaleManSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.SetDeliveryManTime).HasColumnType("datetime");

                entity.Property(e => e.ShipPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShipPriceDosysNo)
                    .HasColumnName("ShipPriceDOSysNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignByOther).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalPoints).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalUsePoints).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UseCoupons).HasMaxLength(2000);

                entity.Property(e => e.Vatemsfee)
                    .HasColumnName("VATEMSFee")
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaitAduitDepartmentSysNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.WaitAduitOperatorSysNo).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SoMasterUpdateHistory>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("SO_Master_UpdateHistory");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AbandonInvoiceTime).HasColumnType("datetime");

                entity.Property(e => e.AuditDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BalancePayAmt).HasColumnType("decimal(19, 6)");

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
                    .HasMaxLength(20)
                    .IsUnicode(false);

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

            modelBuilder.Entity<SoNotification>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__SoNotifi__EB33D9B11AB8C61D");

                entity.HasIndex(e => e.Soid)
                    .HasName("SOId_Index");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NotificationTime).HasColumnType("datetime");

                entity.Property(e => e.NotificationType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Soid)
                    .IsRequired()
                    .HasColumnName("SOID")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SoOutOrder>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_OUT_ORDER");

                entity.ToTable("SO_Out_Order");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");
            });

            modelBuilder.Entity<SoSaleRule>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("SO_SaleRule");

                entity.HasIndex(e => e.SaleRuleSysNo)
                    .HasName("Ncl_Index_SaleRuleSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.SaleRuleName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.HasOne(d => d.SosysNoNavigation)
                    .WithMany(p => p.SoSaleRule)
                    .HasForeignKey(d => d.SosysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SO_SALER_REFERENCE_SO_MASTE");
            });

            modelBuilder.Entity<SoSaleRuleSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_SaleRule_SEQUENCE");

                entity.ToTable("SO_SaleRule_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SoSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_SEQUENCE");

                entity.ToTable("SO_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SoValueAddedInvoice>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_VALUEADDED_INVOICE");

                entity.ToTable("SO_ValueAdded_Invoice");

                entity.HasIndex(e => e.AreaSysNo)
                    .HasName("Ncl_Index_AreaSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.SosysNo)
                    .HasName("Ncl_Index_SOSysNo");

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BankInfo).HasMaxLength(100);

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EleVatdefaultEmail)
                    .HasColumnName("EleVATDefaultEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.TaxNum).HasMaxLength(50);

                entity.Property(e => e.Vatemsfee)
                    .HasColumnName("VATEMSFee")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SounDomasterMark>(entity =>
            {
                entity.HasKey(e => e.SoSysNo)
                    .HasName("PK__SOUnDOMa__4E726C4737EACCFF");

                entity.ToTable("SOUnDOMasterMark");

                entity.Property(e => e.SoSysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MarkSoid)
                    .HasColumnName("MarkSOID")
                    .HasMaxLength(100);

                entity.Property(e => e.MarkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpecialPriceDiscount>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("SpecialPrice_Discount");
            });

            modelBuilder.Entity<SpecialPriceItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SPECIALPRICE_ITEM");

                entity.ToTable("SpecialPrice_Item");

                entity.HasIndex(e => new { e.MasterSysNo, e.IsIconLoad, e.ProductSysNo })
                    .HasName("idx_SpecialPrice_Item_ProductSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.C1sysNo).HasColumnName("C1SysNo");

                entity.Property(e => e.C2sysNo).HasColumnName("C2SysNo");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsIconLoad).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpecialPriceItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SPECIALPRICE_ITEM_SEQUENC");

                entity.ToTable("SpecialPrice_Item_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpecialPriceMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SPECIALPRICE_MASTER");

                entity.ToTable("SpecialPrice_Master");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChannelType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsPromotionInfoShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.PromotionLink).HasMaxLength(200);

                entity.Property(e => e.PromotionWrods).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WebPromotionTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<SpecialPriceMasterSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SPECIALPRICE_MASTER_SEQUENC");

                entity.ToTable("SpecialPrice_Master_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpecialProduct>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SpecSysNo");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("idx_specialproduct_CustomerSysNom");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(20);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Editor).HasMaxLength(20);

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SyncStatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SrMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("SR_Master");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InstockTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ShelveTime).HasColumnType("datetime");

                entity.Property(e => e.SosysNo).HasColumnName("SOSysNo");

                entity.Property(e => e.Srid)
                    .HasColumnName("SRID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StAdjust>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_ADJUST");

                entity.ToTable("St_Adjust");

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.OutUserSysNo)
                    .HasName("Ncl_Index_OutUserSysNo");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AdjustId)
                    .IsRequired()
                    .HasColumnName("AdjustID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");
            });

            modelBuilder.Entity<StAdjustItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_ADJUST_ITEM");

                entity.ToTable("St_Adjust_Item");

                entity.HasIndex(e => e.AdjustSysNo)
                    .HasName("Ncl_Index_AdjustSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.AdjustCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.VatRate).HasColumnType("decimal(19, 8)");

                entity.HasOne(d => d.AdjustSysNoNavigation)
                    .WithMany(p => p.StAdjustItem)
                    .HasForeignKey(d => d.AdjustSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ST_ADJUS_REFERENCE_ST_ADJUS");
            });

            modelBuilder.Entity<StAdjustSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_ADJUST_SEQUENCE");

                entity.ToTable("St_Adjust_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StLend>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_LEND");

                entity.ToTable("St_Lend");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsSyncG7).HasDefaultValueSql("((1))");

                entity.Property(e => e.LendId)
                    .IsRequired()
                    .HasColumnName("LendID")
                    .HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.Receiver).HasMaxLength(50);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverMobilePhone).HasMaxLength(50);

                entity.Property(e => e.ReceiverTelPhone).HasMaxLength(50);

                entity.Property(e => e.Route).HasMaxLength(200);

                entity.Property(e => e.ShipTypeSysNo).HasDefaultValueSql("((5))");

                entity.Property(e => e.SyncStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");
            });

            modelBuilder.Entity<StLendItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_LEND_ITEM");

                entity.ToTable("St_Lend_Item");

                entity.HasIndex(e => e.LendSysNo)
                    .HasName("Ncl_Index_LendSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ExpectReturnTime).HasColumnType("datetime");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.VatRate).HasColumnType("decimal(19, 8)");

                entity.HasOne(d => d.LendSysNoNavigation)
                    .WithMany(p => p.StLendItem)
                    .HasForeignKey(d => d.LendSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ST_LEND__REFERENCE_ST_LEND2");
            });

            modelBuilder.Entity<StLendItemBarcode>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("St_Lend_Item_Barcode");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StLendReturn>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("St_Lend_Return");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AsnsysNo).HasColumnName("ASNSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.HasOne(d => d.LendSysNoNavigation)
                    .WithMany(p => p.StLendReturn)
                    .HasForeignKey(d => d.LendSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ST_LEND__REFERENCE_ST_LEND");
            });

            modelBuilder.Entity<StLendReturnSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_St_Lend_Return_SEQUENCE");

                entity.ToTable("St_Lend_Return_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StLendSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_LEND_SEQUENCE");

                entity.ToTable("St_Lend_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StShift>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_SHIFT");

                entity.ToTable("St_Shift");

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.CheckQtyUserSysNo)
                    .HasName("Ncl_Index_CheckQtyUserSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.DlsysNo)
                    .HasName("Ncl_Index_DLSysNo");

                entity.HasIndex(e => e.FreightUserSysNo)
                    .HasName("Ncl_Index_FreightUserSysNo");

                entity.HasIndex(e => e.InUserSysNo)
                    .HasName("Ncl_Index_InUserSysNo");

                entity.HasIndex(e => e.OutUserSysNo)
                    .HasName("Ncl_Index_OutUserSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CheckQtyTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DlsysNo).HasColumnName("DLSysNo");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.SetDeliveryManTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftId)
                    .IsRequired()
                    .HasColumnName("ShiftID")
                    .HasMaxLength(20);

                entity.Property(e => e.SyncStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TotalNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.Wmsid)
                    .HasColumnName("WMSID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StShiftItem>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("St_Shift_Item");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.HasIndex(e => e.ShiftSysNo)
                    .HasName("Ncl_Index_ShiftSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShiftIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftOut).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.VatRate).HasColumnType("decimal(19, 8)");

                entity.HasOne(d => d.ShiftSysNoNavigation)
                    .WithMany(p => p.StShiftItem)
                    .HasForeignKey(d => d.ShiftSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ST_SHIFT_REFERENCE_ST_SHIFT");
            });

            modelBuilder.Entity<StShiftItemSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_St_Shift_Item_SEQUENCE");

                entity.ToTable("St_Shift_Item_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StShiftSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_SHIFT_SEQUENCE");

                entity.ToTable("St_Shift_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StTransfer>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_TRANSFER");

                entity.ToTable("St_Transfer");

                entity.HasIndex(e => e.AuditUserSysNo)
                    .HasName("Ncl_Index_AuditUserSysNo");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.OutUserSysNo)
                    .HasName("Ncl_Index_OutUserSysNo");

                entity.HasIndex(e => e.StockSysNo)
                    .HasName("Ncl_Index_StockSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.SourceNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.SyncStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TargetNetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.TransferId)
                    .IsRequired()
                    .HasColumnName("TransferID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");
            });

            modelBuilder.Entity<StTransferItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_TRANSFER_ITEM");

                entity.ToTable("St_Transfer_Item");

                entity.HasIndex(e => e.TransferSysNo)
                    .HasName("Ncl_Index_TransferSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransferCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.VatRate).HasColumnType("decimal(19, 8)");

                entity.HasOne(d => d.TransferSysNoNavigation)
                    .WithMany(p => p.StTransferItem)
                    .HasForeignKey(d => d.TransferSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ST_TRANS_REFERENCE_ST_TRANS");
            });

            modelBuilder.Entity<StTransferSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_TRANSFER_SEQUENCE");

                entity.ToTable("St_Transfer_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StVirtual>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_ST_VIRTUAL");

                entity.ToTable("St_Virtual");

                entity.HasIndex(e => e.CreateUserSysNo)
                    .HasName("Ncl_Index_CreateUserSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StockOrderConfig>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__StockOrd__EB33D9B125A8F3D7");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<StockRef>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_STOCK");

                entity.ToTable("Stock_REF");

                entity.HasIndex(e => e.StockId)
                    .HasName("idx_Stock_REF_StockId");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.ChannelType).HasMaxLength(20);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsAutomaticAudit).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendWms).HasColumnName("IsSendWMS");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockId)
                    .IsRequired()
                    .HasColumnName("StockID")
                    .HasMaxLength(20);

                entity.Property(e => e.StockName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockZip).HasMaxLength(50);

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("WarehouseID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StockSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_STOCK_SEQUENCE");

                entity.ToTable("Stock_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Subscribe>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SUBSCRIBE");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.EmailSubscription).HasMaxLength(100);

                entity.Property(e => e.Smssubscription)
                    .HasColumnName("SMSSubscription")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysConfig>(entity =>
            {
                entity.ToTable("sys_config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<SysConfigHandlerMaster>(entity =>
            {
                entity.ToTable("sys_ConfigHandler_Master");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommunicationKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommunicationUserId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogAdd).HasColumnName("logAdd");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysConfigHandlerPath>(entity =>
            {
                entity.ToTable("sys_ConfigHandler_Path");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(150);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SysConfigHandlerPath)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_ConfigHandler_Path_sys_ConfigHandler_Master1");
            });

            modelBuilder.Entity<SysConfigType>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_CONFIGTYPE");

                entity.ToTable("Sys_ConfigType");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<SysDropDownItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Sys_Drop__EB33D9B15E4ED65B");

                entity.ToTable("Sys_DropDown_Item");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DdsysNo).HasColumnName("DDSysNo");

                entity.Property(e => e.ItemDescribe).HasMaxLength(200);

                entity.Property(e => e.ItemName).HasMaxLength(500);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysDropDownMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Sys_Drop__EB33D9B157A1D8CC");

                entity.ToTable("Sys_DropDown_Master");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dddescribe)
                    .HasColumnName("DDDescribe")
                    .HasMaxLength(200);

                entity.Property(e => e.Ddname)
                    .HasColumnName("DDName")
                    .HasMaxLength(200);

                entity.Property(e => e.Ddtag)
                    .HasColumnName("DDTag")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_LOG");

                entity.ToTable("Sys_Log");

                entity.HasIndex(e => e.OptUserSysNo)
                    .HasName("Ncl_Index_OptUserSysNo");

                entity.HasIndex(e => e.TicketSysNo)
                    .HasName("Ncl_Index_TicketSysNo");

                entity.HasIndex(e => new { e.TicketType, e.TicketSysNo })
                    .HasName("sys_LogIndex");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OptIp)
                    .IsRequired()
                    .HasColumnName("OptIP")
                    .HasMaxLength(20);

                entity.Property(e => e.OptTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sys_Menu");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Help)
                    .HasColumnName("help")
                    .HasMaxLength(255);

                entity.Property(e => e.Href)
                    .HasColumnName("href")
                    .HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Privilege).HasMaxLength(500);
            });

            modelBuilder.Entity<SysMenuSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Sys_Menu_SEQUENCE");

                entity.ToTable("Sys_Menu_Sequence");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysOperationType>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sys_OperationType");

                entity.Property(e => e.TypeDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysOperationTypePrivilege>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sys_OperationType_Privilege");

                entity.Property(e => e.OperationTypeId).HasColumnName("OperationTypeID");

                entity.Property(e => e.PrivilegeId).HasColumnName("PrivilegeID");
            });

            modelBuilder.Entity<SysPrivilege>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_PRIVILEGE");

                entity.ToTable("Sys_Privilege");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.PrivilegeId)
                    .IsRequired()
                    .HasColumnName("PrivilegeID")
                    .HasMaxLength(20);

                entity.Property(e => e.PrivilegeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysProtocolSequenceTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SysProtocol_SEQUENCE");

                entity.ToTable("SysProtocol_Sequence_TD");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysProtocolTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SysProtocol");

                entity.ToTable("SysProtocol_TD");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BizData)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasColumnName("EventID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(100);

                entity.Property(e => e.SendType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysRequestAccount>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sys_RequestAccount");

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartMent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_ROLE");

                entity.ToTable("Sys_Role");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.OperationTypeId).HasColumnName("OperationTypeID");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("RoleID")
                    .HasMaxLength(20);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysRolePrivilege>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_ROLE_PRIVILEGE");

                entity.ToTable("Sys_Role_Privilege");

                entity.HasIndex(e => e.PrivilegeSysNo)
                    .HasName("Ncl_Index_PrivilegeSysNo");

                entity.HasIndex(e => e.RoleSysNo)
                    .HasName("Ncl_Index_RoleSysNo");

                entity.HasOne(d => d.PrivilegeSysNoNavigation)
                    .WithMany(p => p.SysRolePrivilege)
                    .HasForeignKey(d => d.PrivilegeSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_ROLE_REFERENCE_SYS_PRIV");

                entity.HasOne(d => d.RoleSysNoNavigation)
                    .WithMany(p => p.SysRolePrivilege)
                    .HasForeignKey(d => d.RoleSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_ROLE_REFERENCE_SYS_ROLE");
            });

            modelBuilder.Entity<SysSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sys_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysStation>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Sys_Station");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.StationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysSync>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_SYNC");

                entity.ToTable("Sys_Sync");

                entity.Property(e => e.LastVersionTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_USER");

                entity.ToTable("Sys_User");

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

                entity.HasIndex(e => new { e.UserName, e.SysNo })
                    .HasName("idx_sys_user_UserID");

                entity.HasIndex(e => new { e.SysNo, e.UserId, e.ParentSysNo, e.DepartmentSysNo, e.MobilePhone, e.StationSysNo, e.PmgroupSysNo, e.Tsrgroup, e.HmcustomerType, e.UserName, e.Pwd, e.Email, e.Phone, e.Note, e.Status, e.Flag })
                    .HasName("idx_Sys_User_Flag");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

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

            modelBuilder.Entity<SysUserCategory>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Sys_User_Category_New");

                entity.ToTable("Sys_User_Category");

                entity.HasIndex(e => e.CategoryRoleSysNo)
                    .HasName("Ncl_Index_CategoryRoleSysNo");

                entity.HasIndex(e => e.CategorySysNo)
                    .HasName("Ncl_Index_CategorySysNo");

                entity.HasIndex(e => e.UserSysNo)
                    .HasName("Ncl_Index_UserSysNo");
            });

            modelBuilder.Entity<SysUserFavoriteLink>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_USER_FAVORITELINK");

                entity.ToTable("Sys_User_FavoriteLink");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LinkAhref)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysUserOut>(entity =>
            {
                entity.HasKey(e => e.Sysno);

                entity.ToTable("Sys_User_Out");

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

            modelBuilder.Entity<SysUserOutSequence>(entity =>
            {
                entity.HasKey(e => e.Sysno)
                    .HasName("PK__Sys_User__EB32DDE976E18148");

                entity.ToTable("Sys_User_Out_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysUserPagePrivilege>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Sys_User__EB33D9B1128CC919");

                entity.ToTable("Sys_UserPagePrivilege");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SysMenuHref)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysUserRole>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SYS_USER_ROLE");

                entity.ToTable("Sys_User_Role");

                entity.HasIndex(e => e.RoleSysNo)
                    .HasName("Ncl_Index_RoleSysNo");

                entity.HasIndex(e => e.UserSysNo)
                    .HasName("Ncl_Index_UserSysNo");

                entity.HasOne(d => d.RoleSysNoNavigation)
                    .WithMany(p => p.SysUserRole)
                    .HasForeignKey(d => d.RoleSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_USER_REFERENCE_SYS_ROLE");

                entity.HasOne(d => d.UserSysNoNavigation)
                    .WithMany(p => p.SysUserRole)
                    .HasForeignKey(d => d.UserSysNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_USER_REFERENCE_SYS_USER");
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

            modelBuilder.Entity<TbrandRepl>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK_TBRAND");

                entity.ToTable("TBrand_REPL");

                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.BrandBriefName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BrandEnglishBriefName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BrandEnglishName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FirstLetter).HasMaxLength(1);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ManufacturerDescription)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.ManufacturerWebSite)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SeoName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
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

            modelBuilder.Entity<TcityRepl>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_TCITY");

                entity.ToTable("TCity_REPL");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TconsumptionExpand>(entity =>
            {
                entity.HasKey(e => e.ConsumptionId)
                    .HasName("PK_TCONSUMPTIONEXPAND");

                entity.ToTable("TConsumptionExpand");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FirstOrderTime).HasColumnType("datetime");

                entity.Property(e => e.LastOrderTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK_TCOUPONBATCH");

                entity.ToTable("TCouponBatch");

                entity.Property(e => e.BatchId).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BatchName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchStatus)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.BatchType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CouponType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DisCount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsShowOnWeb)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SaleAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponBatchChj>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK_TCOUPONBATCH_chj");

                entity.ToTable("TCouponBatch_chj");

                entity.Property(e => e.BatchId).ValueGeneratedNever();

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.BatchName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BatchStatus)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.BatchType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CouponType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DisCount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsShowOnWeb)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SaleAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponDetail>(entity =>
            {
                entity.HasKey(e => e.CouponCodeId)
                    .HasName("PK_TCOUPONDETAIL");

                entity.ToTable("TCouponDetail");

                entity.HasIndex(e => e.BatchId)
                    .HasName("IX_TCouponDetail_batchId");

                entity.Property(e => e.CouponStatus)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsSendMessage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponDetailChj>(entity =>
            {
                entity.HasKey(e => e.CouponCodeId)
                    .HasName("PK_TCOUPONDETAIL_chj");

                entity.ToTable("TCouponDetail_chj");

                entity.Property(e => e.CouponStatus)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IsSendMessage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponGift>(entity =>
            {
                entity.HasKey(e => e.GiftId)
                    .HasName("PK_TCOUPONGIFT");

                entity.ToTable("TCouponGift");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GiftAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponGiftChj>(entity =>
            {
                entity.HasKey(e => e.GiftId)
                    .HasName("PK_TCOUPONGIFT_chj");

                entity.ToTable("TCouponGift_chj");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GiftAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponUseStrategy>(entity =>
            {
                entity.HasKey(e => e.StrategyId)
                    .HasName("PK_TCOUPONUSESTRATEGY");

                entity.ToTable("TCouponUseStrategy");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StrategyType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcouponUseStrategyChj>(entity =>
            {
                entity.HasKey(e => e.StrategyId)
                    .HasName("PK_TCOUPONUSESTRATEGY_chj");

                entity.ToTable("TCouponUseStrategy_chj");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StrategyType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcustomerEtl>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_TCUSTOMER_ETL");

                entity.ToTable("TCustomer_ETL");

                entity.HasIndex(e => new { e.OuterCompanyCode, e.SalesManUserId })
                    .HasName("IX_Test2");

                entity.HasIndex(e => new { e.SalesManUserId, e.OuterCompanyCode })
                    .HasName("IX_TCustomer_ETL_SalesManUserId");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.BriefName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsOrderAutoAudit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsVipNewSite)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.OuterCompanyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcustomerSettlementExpand>(entity =>
            {
                entity.HasKey(e => e.CustomerSettlementId)
                    .HasName("PK_TCUSTOMERSETTLEMENTEXPAND");

                entity.ToTable("TCustomerSettlementExpand");

                entity.Property(e => e.AvalibaleQuota).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.BufferQuota).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SettlementType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TotalQuota).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcustomerSettlementLog>(entity =>
            {
                entity.HasKey(e => e.CustomerSettlementLogId)
                    .HasName("PK_TCUSTOMERSETTLEMENTLOG");

                entity.ToTable("TCustomerSettlementLog");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ReferType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SettlementQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SettlementType)
                    .IsRequired()
                    .HasMaxLength(1);
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

            modelBuilder.Entity<TdistrictRepl>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK_TDISTRICT");

                entity.ToTable("TDistrict_REPL");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(100);

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

            modelBuilder.Entity<TecsitePosition>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.PositionId })
                    .HasName("PK_TECSITEPOSITION");

                entity.ToTable("TECSitePosition");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempUpdateB2bcart>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_tempSysNo");

                entity.ToTable("TempUpdateB2BCart");

                entity.Property(e => e.Cart).HasMaxLength(255);
            });

            modelBuilder.Entity<TfileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_TFILEUPLOAD");

                entity.ToTable("TFileUpload");

                entity.HasIndex(e => e.RelativeId1)
                    .HasName("IX_RelativeId1");

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

            modelBuilder.Entity<TgoodsAttributeClassRepl>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_TGOODSATTRIBUTECLASS");

                entity.ToTable("TGoodsAttributeClass_REPL");

                entity.Property(e => e.ClassId).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsLastLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TgoodsAttributeRepl>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PK_TGOODSATTRIBUTE");

                entity.ToTable("TGoodsAttribute_REPL");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AttributeUnit)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InputType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.OuterName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TgoodsAttributeValueRepl>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId)
                    .HasName("PK_TGOODSATTRIBUTEVALUE");

                entity.ToTable("TGoodsAttributeValue_REPL");

                entity.Property(e => e.AttributeValueName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TgpPromotionDetailRepl>(entity =>
            {
                entity.HasKey(e => e.GpPromotionDetailId)
                    .HasName("PK_TGPPROMOTIONDETAIL");

                entity.ToTable("TGpPromotionDetail_REPL");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IntegralMultiples).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TgpPromotionRepl>(entity =>
            {
                entity.HasKey(e => e.GpPromotionId)
                    .HasName("PK_TGPPROMOTION");

                entity.ToTable("TGpPromotion_REPL");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GpPromotionName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
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

            modelBuilder.Entity<TitemPictureRepl>(entity =>
            {
                entity.HasKey(e => e.PictureId)
                    .HasName("PK_TITEMPICTURE");

                entity.ToTable("TItemPicture_REPL");

                entity.HasIndex(e => new { e.ItemId, e.Status })
                    .HasName("idx_TItemPicture_REPL_ItemId_Status");

                entity.Property(e => e.PictureId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PictureFileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PictureFilePath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TitemRelationGroupDetailRepl>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_TITEMRELATIONGROUPDETAIL");

                entity.ToTable("TItemRelationGroupDetail_REPL");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TitemRelationGroupRepl>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_TITEMRELATIONGROUP");

                entity.ToTable("TItemRelationGroup_REPL");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsUseColor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsUseSpecification)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TitemRepl>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_TITEM");

                entity.ToTable("TItem_REPL");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.AdDescription)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GpRate).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.IsBuyBySets)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsGift)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsSale)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsSaleOnWeb)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemFullName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SearchKeyword)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SkuMaxSalePrice).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.SkuMinSalePrice).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TitemStatistic>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__TItemSta__727E838B1609EAF0");

                entity.ToTable("TItemStatistic");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
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

            modelBuilder.Entity<TlogicalWarehouseRepl>(entity =>
            {
                entity.HasKey(e => e.LogicalWarehouseId)
                    .HasName("PK_TLOGICALWAREHOUSE");

                entity.ToTable("TLogicalWarehouse_REPL");

                entity.Property(e => e.LogicalWarehouseId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutomaticAudit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsSyncWms)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LogicalWarehouseCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LogicalWarehouseFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogicalWarehouseName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogicalWarehouseType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postalcode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WmsWarehouseId)
                    .IsRequired()
                    .HasMaxLength(50);
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

            modelBuilder.Entity<TmailAudit>(entity =>
            {
                entity.HasKey(e => e.MailAuditId)
                    .HasName("PK_TMAILAUDIT");

                entity.ToTable("TMailAudit");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NotificationCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
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

            modelBuilder.Entity<TobjectUtilityApp>(entity =>
            {
                entity.HasKey(e => new { e.ObjectType, e.ObjectId, e.AppId, e.AppType })
                    .HasName("PK_TOBJECTUTILITYAPP");

                entity.ToTable("TObjectUtilityApp");

                entity.Property(e => e.ObjectType).HasMaxLength(20);

                entity.Property(e => e.AppId).HasMaxLength(60);

                entity.Property(e => e.AppType).HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Toccupation>(entity =>
            {
                entity.HasKey(e => e.OccupationId)
                    .HasName("PK_TOCCUPATION");

                entity.ToTable("TOccupation");

                entity.Property(e => e.OccupationId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Features)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OccupationCode)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationName).HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToperationChange>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PK_TOPERATIONCHANGE");

                entity.ToTable("TOperationChange");

                entity.Property(e => e.OperationId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TableKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ToperationChangeDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK_TOPERATIONCHANGEDETAIL");

                entity.ToTable("TOperationChangeDetail");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ToutsourceRule>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleId)
                    .HasName("PK_TOUTSOURCERULE");

                entity.ToTable("TOutsourceRule");

                entity.Property(e => e.OutsourceRuleId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryType).HasMaxLength(1);

                entity.Property(e => e.LimitType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.OutsourceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToutsourceRuleArea>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleAreaId)
                    .HasName("PK_TOUTSOURCERULEAREA");

                entity.ToTable("TOutsourceRuleArea");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToutsourceRuleBrand>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleBrandId)
                    .HasName("PK_TOUTSOURCERULEBRAND");

                entity.ToTable("TOutsourceRuleBrand");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToutsourceRuleCategory>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleCategoryId)
                    .HasName("PK_TOUTSOURCERULECATEGORY");

                entity.ToTable("TOutsourceRuleCategory");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToutsourceRuleHandle>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleHandleId)
                    .HasName("PK_TOUTSOURCERULEHANDLE");

                entity.ToTable("TOutsourceRuleHandle");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleType)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<ToutsourceRuleItemSku>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleItemSkuId)
                    .HasName("PK_TOUTSOURCERULEITEMSKU");

                entity.ToTable("TOutsourceRuleItemSku");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToutsourceRuleUsage>(entity =>
            {
                entity.HasKey(e => e.OutsourceRuleUsageId)
                    .HasName("PK_TOUTSOURCERULEUSAGE");

                entity.ToTable("TOutsourceRuleUsage");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PriorityLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UsageType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ToutsourceTypeLevel>(entity =>
            {
                entity.HasKey(e => e.OutsourceTypeLevelId)
                    .HasName("PK_TOUTSOURCETYPELEVEL");

                entity.ToTable("TOutsourceTypeLevel");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OutsourceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PriorityLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TpayTypeRepl>(entity =>
            {
                entity.HasKey(e => e.PayTypeId)
                    .HasName("PK_TPAYTYPE");

                entity.ToTable("TPayType_REPL");

                entity.Property(e => e.PayTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsWebsiteShow)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayClass)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayPageUrl)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PayTypeCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PayTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TpictureTypeRepl>(entity =>
            {
                entity.HasKey(e => e.PictureTypeId)
                    .HasName("PK_TPICTURETYPE");

                entity.ToTable("TPictureType_REPL");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsNeedWaterMark)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PictureTypeCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PictureTypeName)
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

            modelBuilder.Entity<Tposition>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("PK_TPOSITION");

                entity.ToTable("TPosition");

                entity.Property(e => e.PositionId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FeatureCode)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

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

            modelBuilder.Entity<TproductAttributeValueRepl>(entity =>
            {
                entity.HasKey(e => e.ProductAttributeValueId)
                    .HasName("PK_TPRODUCTATTRIBUTEVALUE");

                entity.ToTable("TProductAttributeValue_REPL");

                entity.Property(e => e.AttributeValue).HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TproductRepl>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_TPRODUCT");

                entity.ToTable("TProduct_REPL");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.AdditionalDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CanPurchase)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CanPurchaseReturn)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CanReturn)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Cube).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.FullContainerBarcode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Has3C)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.HasDimension)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.HasQuanlityStandard)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Height).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.InnerPackageDescription)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.IsBig)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsBulkyCargo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsCloseOut)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsDiscontinue)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsEmbargo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsEnergyConservation)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsFsc)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsGreenProtectionde)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsNewGoods)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsRestrictSaleArea)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Length).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Modal)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModalBrief)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProducingArea)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductFullName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TaxCodeCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(19, 8)")
                    .HasDefaultValueSql("((0.17))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Width).HasColumnType("decimal(19, 8)");
            });

            modelBuilder.Entity<TproductSkuCost>(entity =>
            {
                entity.HasKey(e => e.ProductSkuCostId)
                    .HasName("PK_PRODUCTSKU_COST");

                entity.ToTable("TProductSkuCost");

                entity.HasIndex(e => e.ProductSkuId)
                    .HasName("ProductSkuCost_ProductSkuId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NetCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TproductWarehouse>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.WarehouseId });

                entity.ToTable("TProductWarehouse");

                entity.HasIndex(e => new { e.ProductId, e.WarehouseId, e.PurchaseUserId, e.IsDiscountinue })
                    .HasName("idx_TProductWarehouse_WarehouseId_PurchaseUserId_IsDiscountinue");

                entity.HasIndex(e => new { e.ProductId, e.IsCloseOut, e.IsDiscountinue, e.InventoryTurnover, e.WarehouseId })
                    .HasName("idx_TProductWarehouse_WarehouseId");

                entity.HasIndex(e => new { e.CanPurchase, e.CanPurchaseReturn, e.InventoryTurnover, e.ProductId, e.PoUserId, e.IsCloseOut, e.IsDiscountinue, e.CanReturn, e.WarehouseId, e.PurchaseUserId })
                    .HasName("idx_TProductWarehouse_WarehouseId_PurchaseUserId");

                entity.Property(e => e.CanPurchase)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CanPurchaseReturn)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CanReturn)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InventoryTurnover).HasMaxLength(50);

                entity.Property(e => e.IsCloseOut)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsDiscountinue)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprovinceRepl>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PK_TPROVINCE");

                entity.ToTable("TProvince_REPL");

                entity.Property(e => e.ProvinceId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrabbitMqerror>(entity =>
            {
                entity.HasKey(e => e.RabbitMqerrorId)
                    .HasName("PK_TRABBITMQERROR");

                entity.ToTable("TRabbitMQError");

                entity.Property(e => e.RabbitMqerrorId).HasColumnName("RabbitMQErrorId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchangeName).HasMaxLength(50);

                entity.Property(e => e.QueueName).HasMaxLength(50);
            });

            modelBuilder.Entity<TrackSnBase>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("TrackSN_Base");

                entity.Property(e => e.C3sysNo).HasColumnName("C3SysNo");
            });

            modelBuilder.Entity<TreceivedMessage>(entity =>
            {
                entity.HasKey(e => e.ReceivedMessageId)
                    .HasName("PK_TRECEIVEDMESSAGE");

                entity.ToTable("TReceivedMessage");

                entity.Property(e => e.ReceivedMessageId).ValueGeneratedNever();

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

            modelBuilder.Entity<TriggerDetail>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.CouponBatchNo).HasMaxLength(100);

                entity.Property(e => e.DetailName).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MailSubject).HasMaxLength(200);

                entity.Property(e => e.ReceiveEmails).HasMaxLength(2000);

                entity.Property(e => e.ReceivePhones).HasMaxLength(2000);

                entity.Property(e => e.Smscontent)
                    .HasColumnName("SMSContent")
                    .HasMaxLength(1000);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Times).HasMaxLength(200);

                entity.Property(e => e.TrackingCode).HasMaxLength(200);
            });

            modelBuilder.Entity<TriggerTemplete>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.ContentResult).HasMaxLength(2000);

                entity.Property(e => e.ContentSql).HasMaxLength(4000);

                entity.Property(e => e.DataSql).HasMaxLength(4000);

                entity.Property(e => e.QuerySql).HasMaxLength(4000);

                entity.Property(e => e.TempleteName).HasMaxLength(100);
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

            modelBuilder.Entity<TshipTypeRepl>(entity =>
            {
                entity.HasKey(e => e.ShipTypeId)
                    .HasName("PK_TSHIPTYPE");

                entity.ToTable("TShipType_REPL");

                entity.Property(e => e.ShipTypeId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FreeShipBase).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsSendInvoice)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsShipLarge)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsSynTms)
                    .IsRequired()
                    .HasColumnName("IsSynTMS")
                    .HasMaxLength(1);

                entity.Property(e => e.ServiceLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ShipTypeCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShipTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TshipTypeReplicationRepl>(entity =>
            {
                entity.HasKey(e => e.ShipTypeId)
                    .HasName("PK_TSHIPTYPEREPLICATION");

                entity.ToTable("TShipTypeReplication_REPL");

                entity.Property(e => e.ShipTypeId).ValueGeneratedNever();

                entity.Property(e => e.AccessUrl)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CommunicationKey)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CommunicationUserId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
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

            modelBuilder.Entity<Tsocoupon>(entity =>
            {
                entity.HasKey(e => e.SocouponId)
                    .HasName("PK_TSOCOUPON");

                entity.ToTable("TSOCoupon");

                entity.Property(e => e.SocouponId).HasColumnName("SOCouponId");

                entity.Property(e => e.CouponAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CouponBatchName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CouponBatchType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CouponEndTime).HasColumnType("datetime");

                entity.Property(e => e.CouponType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GiftedItemSkuName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.GiftedItemSkuPrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IsCloseOut)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsDiscontinue)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseCouponThreshold).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<TsomasterUnion>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_SO_MASTER_UNION");

                entity.ToTable("TSOMasterUnion");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnionTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
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

            modelBuilder.Entity<TunitRepl>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK_TUNIT");

                entity.ToTable("TUnit_REPL");

                entity.Property(e => e.UnitId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UnitName)
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

            modelBuilder.Entity<TutilityApp>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK_TUTILITYAPP");

                entity.ToTable("TUtilityApp");

                entity.Property(e => e.AppId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TwarehouseDeliveryAreaRepl>(entity =>
            {
                entity.HasKey(e => new { e.WarehouseId, e.CityId })
                    .HasName("PK_TWAREHOUSEDELIVERYAREA");

                entity.ToTable("TWarehouseDeliveryArea_REPL");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TwarehousePosition>(entity =>
            {
                entity.HasKey(e => new { e.WarehouseId, e.PositionId })
                    .HasName("PK__TWarehou__A003165E4AEC7846");

                entity.ToTable("TWarehousePosition");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TwarehouseRepl>(entity =>
            {
                entity.HasKey(e => e.WarehouseId)
                    .HasName("PK_TWAREHOUSE");

                entity.ToTable("TWarehouse_REPL");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WarehouseCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WarehouseName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TwarehouseShipTypeRepl>(entity =>
            {
                entity.HasKey(e => new { e.WarehouseId, e.ShipTypeId })
                    .HasName("PK_TWAREHOUSESHIPTYPE");

                entity.ToTable("TWarehouseShipType_REPL");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UnspscCatalog>(entity =>
            {
                entity.HasKey(e => e.Sysno)
                    .HasName("PK__UnspscCa__EB32DDE929D02124");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InterfaceCode).HasMaxLength(20);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(20);

                entity.Property(e => e.Unspsc)
                    .HasColumnName("UNSPSC")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Unsubscribe>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<UserOrderDailyReport>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_USERORDERDAILYREPORT");

                entity.Property(e => e.Avgamt)
                    .HasColumnName("AVGAmt")
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.DayAmt)
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Roamt)
                    .HasColumnName("ROAmt")
                    .HasColumnType("decimal(19, 6)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Socount).HasColumnName("SOCount");

                entity.Property(e => e.SopayCount).HasColumnName("SOPayCount");
            });

            modelBuilder.Entity<UserStock>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__User_Sto__EB33D9B165EFF823");

                entity.ToTable("User_Stock");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VaApMap>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__VA_AP_Ma__EB33D9B14AC7009B");

                entity.ToTable("VA_AP_Map");

                entity.Property(e => e.ApsysNo).HasColumnName("APSysNo");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VasysNo).HasColumnName("VASysNo");

                entity.Property(e => e.VendorAdvanceAmt).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_VENDOR");

                entity.HasIndex(e => e.AreaSysNo)
                    .HasName("Ncl_Index_AreaSysNo");

                entity.HasIndex(e => e.FinanceContactAreaSysNo)
                    .HasName("Ncl_Index_FinanceContactAreaSysNo");

                entity.HasIndex(e => e.NegotiationsContactsAreaSysNo)
                    .HasName("Ncl_Index_NegotiationsContactsAreaSysNo");

                entity.HasIndex(e => e.OrderContactsAreaSysNo)
                    .HasName("Ncl_Index_OrderContactsAreaSysNo");

                entity.HasIndex(e => e.WarrantyAreaSysNo)
                    .HasName("Ncl_Index_WarrantyAreaSysNo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Account).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AllowRreceipt)
                    .IsRequired()
                    .HasColumnName("AllowRReceipt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Aptype).HasColumnName("APType");

                entity.Property(e => e.Arday).HasColumnName("ARDay");

                entity.Property(e => e.Artype).HasColumnName("ARType");

                entity.Property(e => e.BackgroundExpectedAmount).HasMaxLength(20);

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.BillingRequirements).HasMaxLength(200);

                entity.Property(e => e.BriefName).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(20);

                entity.Property(e => e.Contact).HasMaxLength(20);

                entity.Property(e => e.ContractDateEnd).HasColumnType("datetime");

                entity.Property(e => e.ContractDateStart).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryRequirements).HasMaxLength(200);

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EnglishName).HasMaxLength(100);

                entity.Property(e => e.EnterpriseLegal).HasMaxLength(20);

                entity.Property(e => e.EstimatedAnnualPurchasesAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.EstimatedAnnualSales).HasMaxLength(20);

                entity.Property(e => e.ExpectedGrossMargin).HasMaxLength(20);

                entity.Property(e => e.ExpectedGrossMarginRate).HasMaxLength(20);

                entity.Property(e => e.ExpectedRebateRatio).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FinanceAddress).HasMaxLength(100);

                entity.Property(e => e.FinanceContact).HasMaxLength(100);

                entity.Property(e => e.FinanceContactMobile).HasMaxLength(50);

                entity.Property(e => e.FinanceContactZip)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceEmail).HasMaxLength(50);

                entity.Property(e => e.FinanceFax).HasMaxLength(50);

                entity.Property(e => e.FinanceMsn)
                    .HasColumnName("FinanceMSN")
                    .HasMaxLength(50);

                entity.Property(e => e.FinanceQq)
                    .HasColumnName("FinanceQQ")
                    .HasMaxLength(50);

                entity.Property(e => e.FinanceTel).HasMaxLength(50);

                entity.Property(e => e.FreightRequirements).HasMaxLength(200);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(200);

                entity.Property(e => e.InvoicePhone).HasMaxLength(20);

                entity.Property(e => e.InvoiceTitle).HasMaxLength(200);

                entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.LogisticsCostsDescribed).HasMaxLength(4000);

                entity.Property(e => e.MinOrderMoney).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.NegotiationsContacts).HasMaxLength(20);

                entity.Property(e => e.NegotiationsContactsAddress).HasMaxLength(100);

                entity.Property(e => e.NegotiationsContactsEmail).HasMaxLength(50);

                entity.Property(e => e.NegotiationsContactsFax).HasMaxLength(50);

                entity.Property(e => e.NegotiationsContactsMobile).HasMaxLength(50);

                entity.Property(e => e.NegotiationsContactsPhone).HasMaxLength(50);

                entity.Property(e => e.NegotiationsContactsZip)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OrderContacts).HasMaxLength(20);

                entity.Property(e => e.OrderContactsAddress).HasMaxLength(100);

                entity.Property(e => e.OrderContactsEmail).HasMaxLength(50);

                entity.Property(e => e.OrderContactsFax).HasMaxLength(50);

                entity.Property(e => e.OrderContactsMobile).HasMaxLength(50);

                entity.Property(e => e.OrderContactsPhone).HasMaxLength(50);

                entity.Property(e => e.OrderContactsZip)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrderRequirements).HasMaxLength(200);

                entity.Property(e => e.OrgCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orman).HasColumnName("ORMan");

                entity.Property(e => e.OtherAccount).HasMaxLength(50);

                entity.Property(e => e.PaymentAgreement).HasMaxLength(4000);

                entity.Property(e => e.PaymentRequirements).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PoMobileTel).HasMaxLength(50);

                entity.Property(e => e.PoMsn)
                    .HasColumnName("PoMSN")
                    .HasMaxLength(50);

                entity.Property(e => e.PoQq)
                    .HasColumnName("PoQQ")
                    .HasMaxLength(50);

                entity.Property(e => e.Poman).HasColumnName("POMan");

                entity.Property(e => e.PromotionalSupport).HasMaxLength(255);

                entity.Property(e => e.PublicityCosts).HasMaxLength(200);

                entity.Property(e => e.PurchaseAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.RcproductPolicy)
                    .HasColumnName("RCProductPolicy")
                    .HasMaxLength(200);

                entity.Property(e => e.RebateCosts).HasMaxLength(200);

                entity.Property(e => e.ReconciliationRequirements).HasMaxLength(200);

                entity.Property(e => e.ReturnRequirements).HasMaxLength(200);

                entity.Property(e => e.Rmaposition)
                    .HasColumnName("RMAPosition")
                    .HasMaxLength(50);

                entity.Property(e => e.Site).HasMaxLength(100);

                entity.Property(e => e.SupplyCategory).HasMaxLength(20);

                entity.Property(e => e.SupplyProduct).HasMaxLength(4000);

                entity.Property(e => e.TaxNo).HasMaxLength(50);

                entity.Property(e => e.TicketDeliveryRequirements).HasMaxLength(200);

                entity.Property(e => e.VarietiesPrice).HasMaxLength(100);

                entity.Property(e => e.VendorAdvanceAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasColumnName("VendorID")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VendorRank).HasDefaultValueSql("((1))");

                entity.Property(e => e.WarrantyAddress).HasMaxLength(100);

                entity.Property(e => e.WarrantyContact).HasMaxLength(20);

                entity.Property(e => e.WarrantyEmail).HasMaxLength(50);

                entity.Property(e => e.WarrantyFax).HasMaxLength(50);

                entity.Property(e => e.WarrantyMsn)
                    .HasColumnName("WarrantyMSN")
                    .HasMaxLength(50);

                entity.Property(e => e.WarrantyPhone).HasMaxLength(50);

                entity.Property(e => e.WarrantyQq)
                    .HasColumnName("WarrantyQQ")
                    .HasMaxLength(50);

                entity.Property(e => e.WarrantySite).HasMaxLength(100);

                entity.Property(e => e.WarrantyZip).HasMaxLength(10);

                entity.Property(e => e.Zip).HasMaxLength(10);
            });

            modelBuilder.Entity<VendorAdvanceAmtItem>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Vendor_A__EB33D9B1413D9661");

                entity.ToTable("Vendor_AdvanceAmt_Item");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pcount).HasColumnName("PCount");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VasysNo).HasColumnName("VASysNo");
            });

            modelBuilder.Entity<VendorReplenishmentDays>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__Vendor_R__EB33D9B13AEEF4D7");

                entity.ToTable("Vendor_ReplenishmentDays");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReplenishDayIndex)
                    .IsRequired()
                    .HasMaxLength(31);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VendorSequence>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_VENDOR_SEQUENCE");

                entity.ToTable("Vendor_Sequence");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VerifySyncHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.Property(e => e.CreatTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.OperateType).HasMaxLength(2);

                entity.Property(e => e.ReferEndAmt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ReferType).HasMaxLength(2);

                entity.Property(e => e.VerificationTime).HasColumnType("datetime");

                entity.Property(e => e.VerificationType).HasMaxLength(2);
            });

            modelBuilder.Entity<VipoleToNewCustomer>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__VIPOleTo__EB33D9B1552EB51E");

                entity.ToTable("VIPOleToNew_Customer");

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

                entity.Property(e => e.BdbonusDeadline)
                    .HasColumnName("BDbonusDeadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BufferAccountQuota).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BuyTime).HasColumnType("datetime");

                entity.Property(e => e.CardNo).HasMaxLength(50);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

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

                entity.Property(e => e.DwellAddress).HasMaxLength(200);

                entity.Property(e => e.DwellZip).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpNumber).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FreightDemand).HasMaxLength(100);

                entity.Property(e => e.Industry).HasMaxLength(100);

                entity.Property(e => e.InvalidReason).HasMaxLength(500);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.IsBdbonusChanged).HasColumnName("IsBDbonusChanged");

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

            modelBuilder.Entity<VipoleToNewCustomerAddress>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__VIPOleTo__EB33D9B160A067CA");

                entity.ToTable("VIPOleToNew_Customer_Address");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Brief).HasMaxLength(50);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.DistributionCode).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ReceivePasphone)
                    .HasColumnName("ReceivePASPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<VipoleToNewCustomerDepartment>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__VIPOleTo__EB33D9B16470F8AE");

                entity.ToTable("VIPOleToNew_Customer_Department");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ApprovalAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.BillingRequirements).HasMaxLength(100);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(200);

                entity.Property(e => e.DeliveryRequirements).HasMaxLength(100);

                entity.Property(e => e.DepartmentCompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FinanceContacts).HasMaxLength(50);

                entity.Property(e => e.FinancialContactAddress).HasMaxLength(100);

                entity.Property(e => e.FinancialContactFax).HasMaxLength(50);

                entity.Property(e => e.FinancialContactMobilePhone).HasMaxLength(50);

                entity.Property(e => e.FinancialContactPhone).HasMaxLength(50);

                entity.Property(e => e.FinancialMailContact).HasMaxLength(50);

                entity.Property(e => e.FinancialZip).HasMaxLength(50);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.MonBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MonRemainder).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MonRemainderUpdateDatetime).HasColumnType("datetime");

                entity.Property(e => e.NextMonBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.NextMonTime).HasColumnType("datetime");

                entity.Property(e => e.NextYearBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.NextYearTime).HasColumnType("datetime");

                entity.Property(e => e.OrderBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PaymentRequest).HasMaxLength(100);

                entity.Property(e => e.ReconciliationRequirements).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.YearBudget).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.YearRemainder).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.YearRemainderUpdateDatetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VipoleToNewCustomerVatInfo>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__VIPOleTo__EB33D9B15CCFD6E6");

                entity.ToTable("VIPOleToNew_Customer_VatInfo");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.BankInfo).HasMaxLength(100);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

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

            modelBuilder.Entity<VipoleToNewOperator>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK__VIPOleTo__EB33D9B158FF4602");

                entity.ToTable("VIPOleToNew_Operator");

                entity.Property(e => e.SysNo).ValueGeneratedNever();

                entity.Property(e => e.ApprovalAmount).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Cart).HasColumnType("text");

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ContactAddress).HasMaxLength(100);

                entity.Property(e => e.ContactAddressSysNo).HasColumnName("ContactAddressSysNO");

                entity.Property(e => e.ContactMobilePhone).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactZip).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasMaxLength(100);

                entity.Property(e => e.LoginName).HasMaxLength(100);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperatorName).HasMaxLength(50);

                entity.Property(e => e.OperatorPwd).HasMaxLength(50);

                entity.Property(e => e.OperatorShowModel).HasColumnType("text");

                entity.Property(e => e.SentInvoiceAddress).HasMaxLength(100);

                entity.Property(e => e.ShowType).HasMaxLength(1000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WaybillMaster>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.ToTable("Waybill_Master");

                entity.HasIndex(e => e.DosysNo)
                    .HasName("Ncl_Index_DOSysNo");

                entity.HasIndex(e => e.WaybillNo)
                    .HasName("Ncl_Index_WaybillNO");

                entity.HasIndex(e => new { e.SysNo, e.DosysNo, e.WaybillNo, e.AsyncState, e.ShipTypeSysno })
                    .HasName("idx_Waybill_Master_AsyncState_ShipTypeSysno");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Doid)
                    .IsRequired()
                    .HasColumnName("DOID")
                    .HasMaxLength(120)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DosysNo).HasColumnName("DOSysNo");

                entity.Property(e => e.ErrorMessage).HasMaxLength(100);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SequenceNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShipTypeSysno).HasDefaultValueSql("((5))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WaybillNo)
                    .IsRequired()
                    .HasColumnName("WaybillNO")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WebBulletin>(entity =>
            {
                entity.HasKey(e => e.SysNo);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsScoll).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowForums).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_WISHLIST");

                entity.HasIndex(e => e.CustomerSysNo)
                    .HasName("Ncl_Index_CustomerSysNo");

                entity.HasIndex(e => e.OperatorSysNo)
                    .HasName("Ncl_Index_OperatorSysNo");

                entity.HasIndex(e => e.ProductSysNo)
                    .HasName("Ncl_Index_ProductSysNo");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(1000);
            });

            modelBuilder.Entity<WmsDeliverNo>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_WMS_DELIVERYNO_ERROR");

                entity.ToTable("WMS_DeliverNo");

                entity.Property(e => e.Addtime)
                    .HasColumnName("ADDTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deliveryno)
                    .IsRequired()
                    .HasColumnName("DELIVERYNO")
                    .HasMaxLength(20);

                entity.Property(e => e.Docno)
                    .IsRequired()
                    .HasColumnName("DOCNO")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<WorkdayTd>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PK_Workday");

                entity.ToTable("Workday_TD");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
