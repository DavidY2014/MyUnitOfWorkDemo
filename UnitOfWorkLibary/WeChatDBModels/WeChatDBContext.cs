using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WeChatDBContext : DbContext
    {
        public WeChatDBContext()
        {
        }

        public WeChatDBContext(DbContextOptions<WeChatDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DtArticle> DtArticle { get; set; }
        public virtual DbSet<DtArticleAlbums> DtArticleAlbums { get; set; }
        public virtual DbSet<DtArticleAttach> DtArticleAttach { get; set; }
        public virtual DbSet<DtArticleAttributeField> DtArticleAttributeField { get; set; }
        public virtual DbSet<DtArticleAttributeValue> DtArticleAttributeValue { get; set; }
        public virtual DbSet<DtArticleCategory> DtArticleCategory { get; set; }
        public virtual DbSet<DtArticleComment> DtArticleComment { get; set; }
        public virtual DbSet<DtChannel> DtChannel { get; set; }
        public virtual DbSet<DtChannelCategory> DtChannelCategory { get; set; }
        public virtual DbSet<DtChannelField> DtChannelField { get; set; }
        public virtual DbSet<DtExpress> DtExpress { get; set; }
        public virtual DbSet<DtFeedback> DtFeedback { get; set; }
        public virtual DbSet<DtLink> DtLink { get; set; }
        public virtual DbSet<DtMailTemplate> DtMailTemplate { get; set; }
        public virtual DbSet<DtManager> DtManager { get; set; }
        public virtual DbSet<DtManagerLog> DtManagerLog { get; set; }
        public virtual DbSet<DtManagerRole> DtManagerRole { get; set; }
        public virtual DbSet<DtManagerRoleValue> DtManagerRoleValue { get; set; }
        public virtual DbSet<DtNavigation> DtNavigation { get; set; }
        public virtual DbSet<DtOrderGoods> DtOrderGoods { get; set; }
        public virtual DbSet<DtOrders> DtOrders { get; set; }
        public virtual DbSet<DtPayment> DtPayment { get; set; }
        public virtual DbSet<DtSmsTemplate> DtSmsTemplate { get; set; }
        public virtual DbSet<DtUserAmountLog> DtUserAmountLog { get; set; }
        public virtual DbSet<DtUserCode> DtUserCode { get; set; }
        public virtual DbSet<DtUserGroupPrice> DtUserGroupPrice { get; set; }
        public virtual DbSet<DtUserGroups> DtUserGroups { get; set; }
        public virtual DbSet<DtUserLoginLog> DtUserLoginLog { get; set; }
        public virtual DbSet<DtUserMessage> DtUserMessage { get; set; }
        public virtual DbSet<DtUserOauth> DtUserOauth { get; set; }
        public virtual DbSet<DtUserOauthApp> DtUserOauthApp { get; set; }
        public virtual DbSet<DtUserPointLog> DtUserPointLog { get; set; }
        public virtual DbSet<DtUsers> DtUsers { get; set; }
        public virtual DbSet<PreCommonDistrict> PreCommonDistrict { get; set; }
        public virtual DbSet<WxAgentInfo> WxAgentInfo { get; set; }
        public virtual DbSet<WxAlbumsInfo> WxAlbumsInfo { get; set; }
        public virtual DbSet<WxAlbumsPhoto> WxAlbumsPhoto { get; set; }
        public virtual DbSet<WxAlbumsSys> WxAlbumsSys { get; set; }
        public virtual DbSet<WxAlbumsType> WxAlbumsType { get; set; }
        public virtual DbSet<WxCards> WxCards { get; set; }
        public virtual DbSet<WxCardsGl> WxCardsGl { get; set; }
        public virtual DbSet<WxDiancaiBlacklist> WxDiancaiBlacklist { get; set; }
        public virtual DbSet<WxDiancaiCaipinCategory> WxDiancaiCaipinCategory { get; set; }
        public virtual DbSet<WxDiancaiCaipinManage> WxDiancaiCaipinManage { get; set; }
        public virtual DbSet<WxDiancaiDesknum> WxDiancaiDesknum { get; set; }
        public virtual DbSet<WxDiancaiDianyuan> WxDiancaiDianyuan { get; set; }
        public virtual DbSet<WxDiancaiDingdanCaiping> WxDiancaiDingdanCaiping { get; set; }
        public virtual DbSet<WxDiancaiDingdanManage> WxDiancaiDingdanManage { get; set; }
        public virtual DbSet<WxDiancaiFormControl> WxDiancaiFormControl { get; set; }
        public virtual DbSet<WxDiancaiFormResult> WxDiancaiFormResult { get; set; }
        public virtual DbSet<WxDiancaiMember> WxDiancaiMember { get; set; }
        public virtual DbSet<WxDiancaiShopAdvertisement> WxDiancaiShopAdvertisement { get; set; }
        public virtual DbSet<WxDiancaiShopSetup> WxDiancaiShopSetup { get; set; }
        public virtual DbSet<WxDiancaiShopinfo> WxDiancaiShopinfo { get; set; }
        public virtual DbSet<WxDiancaiShoppic> WxDiancaiShoppic { get; set; }
        public virtual DbSet<WxDzpActionInfo> WxDzpActionInfo { get; set; }
        public virtual DbSet<WxDzpAwardItem> WxDzpAwardItem { get; set; }
        public virtual DbSet<WxDzpAwardUser> WxDzpAwardUser { get; set; }
        public virtual DbSet<WxDzpUsersTemp> WxDzpUsersTemp { get; set; }
        public virtual DbSet<WxGgkActionInfo> WxGgkActionInfo { get; set; }
        public virtual DbSet<WxGgkAwardItem> WxGgkAwardItem { get; set; }
        public virtual DbSet<WxGgkAwardUser> WxGgkAwardUser { get; set; }
        public virtual DbSet<WxGgkUsersTemp> WxGgkUsersTemp { get; set; }
        public virtual DbSet<WxLbsSetting> WxLbsSetting { get; set; }
        public virtual DbSet<WxLbsShopInfo> WxLbsShopInfo { get; set; }
        public virtual DbSet<WxLinkModule> WxLinkModule { get; set; }
        public virtual DbSet<WxLogs> WxLogs { get; set; }
        public virtual DbSet<WxManagerBill> WxManagerBill { get; set; }
        public virtual DbSet<WxMessageBlacklist> WxMessageBlacklist { get; set; }
        public virtual DbSet<WxMessageList> WxMessageList { get; set; }
        public virtual DbSet<WxMessageSetting> WxMessageSetting { get; set; }
        public virtual DbSet<WxModuleTemplates> WxModuleTemplates { get; set; }
        public virtual DbSet<WxModuleTemplatesWcode> WxModuleTemplatesWcode { get; set; }
        public virtual DbSet<WxOrderTemp> WxOrderTemp { get; set; }
        public virtual DbSet<WxPanoJd> WxPanoJd { get; set; }
        public virtual DbSet<WxPanoSys> WxPanoSys { get; set; }
        public virtual DbSet<WxPaymentAlipay> WxPaymentAlipay { get; set; }
        public virtual DbSet<WxPaymentType> WxPaymentType { get; set; }
        public virtual DbSet<WxPaymentWxpay> WxPaymentWxpay { get; set; }
        public virtual DbSet<WxPicStore> WxPicStore { get; set; }
        public virtual DbSet<WxProduct> WxProduct { get; set; }
        public virtual DbSet<WxProductComment> WxProductComment { get; set; }
        public virtual DbSet<WxProductSys> WxProductSys { get; set; }
        public virtual DbSet<WxProductType> WxProductType { get; set; }
        public virtual DbSet<WxPropertyInfo> WxPropertyInfo { get; set; }
        public virtual DbSet<WxPurchaseBase> WxPurchaseBase { get; set; }
        public virtual DbSet<WxPurchaseCustomer> WxPurchaseCustomer { get; set; }
        public virtual DbSet<WxRequestRule> WxRequestRule { get; set; }
        public virtual DbSet<WxRequestRuleContent> WxRequestRuleContent { get; set; }
        public virtual DbSet<WxRequstBaseData> WxRequstBaseData { get; set; }
        public virtual DbSet<WxResponseBaseData> WxResponseBaseData { get; set; }
        public virtual DbSet<WxSTicket> WxSTicket { get; set; }
        public virtual DbSet<WxShopAlbums> WxShopAlbums { get; set; }
        public virtual DbSet<WxShopBrand> WxShopBrand { get; set; }
        public virtual DbSet<WxShopCart> WxShopCart { get; set; }
        public virtual DbSet<WxShopCatalog> WxShopCatalog { get; set; }
        public virtual DbSet<WxShopCatalogAttribute> WxShopCatalogAttribute { get; set; }
        public virtual DbSet<WxShopCategory> WxShopCategory { get; set; }
        public virtual DbSet<WxShopCategoryCatalog> WxShopCategoryCatalog { get; set; }
        public virtual DbSet<WxShopComment> WxShopComment { get; set; }
        public virtual DbSet<WxShopProduct> WxShopProduct { get; set; }
        public virtual DbSet<WxShopProductAttrValue> WxShopProductAttrValue { get; set; }
        public virtual DbSet<WxShopSetting> WxShopSetting { get; set; }
        public virtual DbSet<WxShopSku> WxShopSku { get; set; }
        public virtual DbSet<WxShopUserAddr> WxShopUserAddr { get; set; }
        public virtual DbSet<WxSjbBisai> WxSjbBisai { get; set; }
        public virtual DbSet<WxSjbJcDetail> WxSjbJcDetail { get; set; }
        public virtual DbSet<WxSjbQiudui> WxSjbQiudui { get; set; }
        public virtual DbSet<WxSjbRicheng> WxSjbRicheng { get; set; }
        public virtual DbSet<WxSjbUsers> WxSjbUsers { get; set; }
        public virtual DbSet<WxSmallLink> WxSmallLink { get; set; }
        public virtual DbSet<WxSmsConfig> WxSmsConfig { get; set; }
        public virtual DbSet<WxSmsInfo> WxSmsInfo { get; set; }
        public virtual DbSet<WxSqAct> WxSqAct { get; set; }
        public virtual DbSet<WxSqHeimd> WxSqHeimd { get; set; }
        public virtual DbSet<WxSqPiclist> WxSqPiclist { get; set; }
        public virtual DbSet<WxSttAwardItem> WxSttAwardItem { get; set; }
        public virtual DbSet<WxSttAwardUser> WxSttAwardUser { get; set; }
        public virtual DbSet<WxSysConfig> WxSysConfig { get; set; }
        public virtual DbSet<WxTemplates> WxTemplates { get; set; }
        public virtual DbSet<WxTemplatesWcode> WxTemplatesWcode { get; set; }
        public virtual DbSet<WxUcardAdver> WxUcardAdver { get; set; }
        public virtual DbSet<WxUcardCardinfo> WxUcardCardinfo { get; set; }
        public virtual DbSet<WxUcardGift> WxUcardGift { get; set; }
        public virtual DbSet<WxUcardNotice> WxUcardNotice { get; set; }
        public virtual DbSet<WxUcardPrivileges> WxUcardPrivileges { get; set; }
        public virtual DbSet<WxUcardScore> WxUcardScore { get; set; }
        public virtual DbSet<WxUcardStore> WxUcardStore { get; set; }
        public virtual DbSet<WxUcardStoreFendian> WxUcardStoreFendian { get; set; }
        public virtual DbSet<WxUcardSys> WxUcardSys { get; set; }
        public virtual DbSet<WxUcardTicket> WxUcardTicket { get; set; }
        public virtual DbSet<WxUcardUdegree> WxUcardUdegree { get; set; }
        public virtual DbSet<WxUcardUsercard> WxUcardUsercard { get; set; }
        public virtual DbSet<WxUcardUsers> WxUcardUsers { get; set; }
        public virtual DbSet<WxUcardUsersConsumeinfo> WxUcardUsersConsumeinfo { get; set; }
        public virtual DbSet<WxUserGroup> WxUserGroup { get; set; }
        public virtual DbSet<WxUserinfo> WxUserinfo { get; set; }
        public virtual DbSet<WxUserweixin> WxUserweixin { get; set; }
        public virtual DbSet<WxVoteBase> WxVoteBase { get; set; }
        public virtual DbSet<WxVoteItem> WxVoteItem { get; set; }
        public virtual DbSet<WxVoteResult> WxVoteResult { get; set; }
        public virtual DbSet<WxWifi> WxWifi { get; set; }
        public virtual DbSet<WxWsiteModulebase> WxWsiteModulebase { get; set; }
        public virtual DbSet<WxWsiteSetting> WxWsiteSetting { get; set; }
        public virtual DbSet<WxXtBase> WxXtBase { get; set; }
        public virtual DbSet<WxXtPhoto> WxXtPhoto { get; set; }
        public virtual DbSet<WxXtUser> WxXtUser { get; set; }
        public virtual DbSet<WxXtZhufu> WxXtZhufu { get; set; }
        public virtual DbSet<WxYyBase> WxYyBase { get; set; }
        public virtual DbSet<WxYyControl> WxYyControl { get; set; }
        public virtual DbSet<WxYyResult> WxYyResult { get; set; }
        public virtual DbSet<WxYyyActionInfo> WxYyyActionInfo { get; set; }
        public virtual DbSet<WxYyyAwardItem> WxYyyAwardItem { get; set; }
        public virtual DbSet<WxYyyAwardUser> WxYyyAwardUser { get; set; }
        public virtual DbSet<WxYyyUsersTemp> WxYyyUsersTemp { get; set; }

        // Unable to generate entity type for table 'dbo.testtb'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server= 47.98.106.199;User ID=sa;Password=Maxwell110;Database=WeChatDB;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DtArticle>(entity =>
            {
                entity.ToTable("dt_article");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.Click)
                    .HasColumnName("click")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.GroupidsView)
                    .HasColumnName("groupids_view")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsHot)
                    .HasColumnName("is_hot")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMsg)
                    .HasColumnName("is_msg")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRed)
                    .HasColumnName("is_red")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSlide)
                    .HasColumnName("is_slide")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTop)
                    .HasColumnName("is_top")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.VoteId)
                    .HasColumnName("vote_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.Zhaiyao)
                    .HasColumnName("zhaiyao")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DtArticleAlbums>(entity =>
            {
                entity.ToTable("dt_article_albums");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalPath)
                    .HasColumnName("original_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThumbPath)
                    .HasColumnName("thumb_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtArticleAttach>(entity =>
            {
                entity.ToTable("dt_article_attach");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DownNum)
                    .HasColumnName("down_num")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FileExt)
                    .HasColumnName("file_ext")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtArticleAttributeField>(entity =>
            {
                entity.ToTable("dt_article_attribute_field");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControlType)
                    .HasColumnName("control_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DataLength)
                    .HasColumnName("data_length")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DataPlace)
                    .HasColumnName("data_place")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("default_value")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditorType)
                    .HasColumnName("editor_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsHtml)
                    .HasColumnName("is_html")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPassword)
                    .HasColumnName("is_password")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRequired)
                    .HasColumnName("is_required")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemOption)
                    .HasColumnName("item_option")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValidErrorMsg)
                    .HasColumnName("valid_error_msg")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValidPattern)
                    .HasColumnName("valid_pattern")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValidTipMsg)
                    .HasColumnName("valid_tip_msg")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DtArticleAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK_DT_ARTICLE_ATTRIBUTE_VALUE");

                entity.ToTable("dt_article_attribute_value");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ddd)
                    .HasColumnName("ddd")
                    .HasMaxLength(1);

                entity.Property(e => e.GoodsNo)
                    .HasColumnName("goods_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarketPrice)
                    .HasColumnName("market_price")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SellPrice)
                    .HasColumnName("sell_price")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockQuantity)
                    .HasColumnName("stock_quantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubTitle)
                    .HasColumnName("sub_title")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Article)
                    .WithOne(p => p.DtArticleAttributeValue)
                    .HasForeignKey<DtArticleAttributeValue>(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DT_ARTIC_REFERENCE_DT_ARTIC");
            });

            modelBuilder.Entity<DtArticleCategory>(entity =>
            {
                entity.ToTable("dt_article_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.ClassLayer)
                    .HasColumnName("class_layer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassList)
                    .HasColumnName("class_list")
                    .HasMaxLength(500);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IcoUrl)
                    .HasColumnName("ico_url")
                    .HasMaxLength(500);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtArticleComment>(entity =>
            {
                entity.ToTable("dt_article_comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChannelId)
                    .HasColumnName("channel_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReply)
                    .HasColumnName("is_reply")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplyContent)
                    .HasColumnName("reply_content")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReplyTime)
                    .HasColumnName("reply_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtChannel>(entity =>
            {
                entity.ToTable("dt_channel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAlbums)
                    .HasColumnName("is_albums")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAttach)
                    .HasColumnName("is_attach")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGroupPrice)
                    .HasColumnName("is_group_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageSize)
                    .HasColumnName("page_size")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DtChannel)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_DT_CHANN_REFERENCE_DT_CATEGORY");
            });

            modelBuilder.Entity<DtChannelCategory>(entity =>
            {
                entity.ToTable("dt_channel_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildPath)
                    .HasColumnName("build_path")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.TempletPath)
                    .HasColumnName("templet_path")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtChannelField>(entity =>
            {
                entity.ToTable("dt_channel_field");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.FieldId).HasColumnName("field_id");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.DtChannelField)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DT_CHANN_REFERENCE_DT_CHANN_FIELD");
            });

            modelBuilder.Entity<DtExpress>(entity =>
            {
                entity.ToTable("dt_express");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpressCode)
                    .HasColumnName("express_code")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpressFee)
                    .HasColumnName("express_fee")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtFeedback>(entity =>
            {
                entity.ToTable("dt_feedback");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsLock).HasColumnName("is_lock");

                entity.Property(e => e.ReplyContent)
                    .HasColumnName("reply_content")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReplyTime)
                    .HasColumnName("reply_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserQq)
                    .HasColumnName("user_qq")
                    .HasMaxLength(30);

                entity.Property(e => e.UserTel)
                    .HasColumnName("user_tel")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DtLink>(entity =>
            {
                entity.ToTable("dt_link");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255);

                entity.Property(e => e.IsImage).HasColumnName("is_image");

                entity.Property(e => e.IsLock).HasColumnName("is_lock");

                entity.Property(e => e.IsRed).HasColumnName("is_red");

                entity.Property(e => e.SiteUrl)
                    .HasColumnName("site_url")
                    .HasMaxLength(255);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserTel)
                    .HasColumnName("user_tel")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DtMailTemplate>(entity =>
            {
                entity.ToTable("dt_mail_template");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaillTitle)
                    .HasColumnName("maill_title")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtManager>(entity =>
            {
                entity.ToTable("dt_manager");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.AgentLevel).HasColumnName("agentLevel");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(200);

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30);

                entity.Property(e => e.IsLock).HasColumnName("is_lock");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(200);

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(30);

                entity.Property(e => e.RealName)
                    .HasColumnName("real_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegIp)
                    .HasColumnName("reg_ip")
                    .HasMaxLength(30);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1500);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleType).HasColumnName("role_type");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(20);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.WxNum).HasColumnName("wxNum");
            });

            modelBuilder.Entity<DtManagerLog>(entity =>
            {
                entity.ToTable("dt_manager_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(100);

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtManagerRole>(entity =>
            {
                entity.ToTable("dt_manager_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RoleType).HasColumnName("role_type");
            });

            modelBuilder.Entity<DtManagerRoleValue>(entity =>
            {
                entity.ToTable("dt_manager_role_value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(50);

                entity.Property(e => e.NavName)
                    .HasColumnName("nav_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.DtManagerRoleValue)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_DT_MANAG_REFERENCE_DT_MANAG");
            });

            modelBuilder.Entity<DtNavigation>(entity =>
            {
                entity.ToTable("dt_navigation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChannelId)
                    .HasColumnName("channel_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassLayer)
                    .HasColumnName("class_layer")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClassList)
                    .HasColumnName("class_list")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NavType)
                    .HasColumnName("nav_type")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.SubTitle)
                    .HasColumnName("sub_title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DtOrderGoods>(entity =>
            {
                entity.ToTable("dt_order_goods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.Property(e => e.GoodsPrice)
                    .HasColumnName("goods_price")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GoodsTitle)
                    .HasColumnName("goods_title")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RealPrice)
                    .HasColumnName("real_price")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DtOrderGoods)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DT_ORDER_REFERENCE_DT_ORDER");
            });

            modelBuilder.Entity<DtOrders>(entity =>
            {
                entity.ToTable("dt_orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptName)
                    .HasColumnName("accept_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompleteTime)
                    .HasColumnName("complete_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConfirmTime)
                    .HasColumnName("confirm_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressFee)
                    .HasColumnName("express_fee")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpressId)
                    .HasColumnName("express_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpressNo)
                    .HasColumnName("express_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpressStatus)
                    .HasColumnName("express_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpressTime)
                    .HasColumnName("express_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FahuoCode)
                    .HasColumnName("fahuoCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FahuoMsg)
                    .HasColumnName("fahuoMsg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsSubscribe).HasColumnName("isSubscribe");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModelActionId).HasColumnName("modelActionId");

                entity.Property(e => e.ModelActionName)
                    .HasColumnName("modelActionName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("modelCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasColumnName("modelName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyId)
                    .HasColumnName("notify_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasColumnName("order_amount")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderSubject)
                    .HasColumnName("orderSubject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayInfo)
                    .HasColumnName("pay_info")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAmount)
                    .HasColumnName("payable_amount")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentFee)
                    .HasColumnName("payment_fee")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentStatus)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentTime)
                    .HasColumnName("payment_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCode)
                    .HasColumnName("post_code")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RealAmount)
                    .HasColumnName("real_amount")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TradeNo)
                    .HasColumnName("trade_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtPayment>(entity =>
            {
                entity.ToTable("dt_payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiPath)
                    .HasColumnName("api_path")
                    .HasMaxLength(100);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PTypeId).HasColumnName("pTypeId");

                entity.Property(e => e.PoundageAmount)
                    .HasColumnName("poundage_amount")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PoundageType)
                    .HasColumnName("poundage_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<DtSmsTemplate>(entity =>
            {
                entity.ToTable("dt_sms_template");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallIndex)
                    .HasColumnName("call_index")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsSys)
                    .HasColumnName("is_sys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DtUserAmountLog>(entity =>
            {
                entity.ToTable("dt_user_amount_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CompleteTime)
                    .HasColumnName("complete_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TradeNo)
                    .HasColumnName("trade_no")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DtUserCode>(entity =>
            {
                entity.ToTable("dt_user_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EffTime)
                    .HasColumnName("eff_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StrCode)
                    .HasColumnName("str_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DtUserCode)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DT_USER__REFERENCE_DT_USERS_CODE");
            });

            modelBuilder.Entity<DtUserGroupPrice>(entity =>
            {
                entity.ToTable("dt_user_group_price");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DtUserGroups>(entity =>
            {
                entity.ToTable("dt_user_groups");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUpgrade)
                    .HasColumnName("is_upgrade")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpgradeExp)
                    .HasColumnName("upgrade_exp")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DtUserLoginLog>(entity =>
            {
                entity.ToTable("dt_user_login_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginIp)
                    .HasColumnName("login_ip")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginTime)
                    .HasColumnName("login_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DtUserLoginLog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DT_USER__REFERENCE_DT_USERS_LOG");
            });

            modelBuilder.Entity<DtUserMessage>(entity =>
            {
                entity.ToTable("dt_user_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptUserName)
                    .HasColumnName("accept_user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsRead)
                    .HasColumnName("is_read")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostTime)
                    .HasColumnName("post_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostUserName)
                    .HasColumnName("post_user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ReadTime)
                    .HasColumnName("read_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DtUserOauth>(entity =>
            {
                entity.ToTable("dt_user_oauth");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OauthAccessToken)
                    .HasColumnName("oauth_access_token")
                    .HasMaxLength(500);

                entity.Property(e => e.OauthName)
                    .IsRequired()
                    .HasColumnName("oauth_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.OauthOpenid)
                    .HasColumnName("oauth_openid")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DtUserOauthApp>(entity =>
            {
                entity.ToTable("dt_user_oauth_app");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiPath)
                    .HasColumnName("api_path")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasMaxLength(100);

                entity.Property(e => e.AppKey)
                    .HasColumnName("app_key")
                    .HasMaxLength(500);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLock)
                    .HasColumnName("is_lock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DtUserPointLog>(entity =>
            {
                entity.ToTable("dt_user_point_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<DtUsers>(entity =>
            {
                entity.ToTable("dt_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Exp)
                    .HasColumnName("exp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Isweixin).HasColumnName("isweixin");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NickName)
                    .HasColumnName("nick_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegIp)
                    .HasColumnName("reg_ip")
                    .HasMaxLength(30);

                entity.Property(e => e.RegTime)
                    .HasColumnName("reg_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SafeAnswer)
                    .HasColumnName("safe_answer")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SafeQuestion)
                    .HasColumnName("safe_question")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(20);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('保密')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.WxName)
                    .HasColumnName("wxName")
                    .HasMaxLength(150);

                entity.Property(e => e.WxOpenId)
                    .HasColumnName("wxOpenId")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DtUsers)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DT_USERS_REFERENCE_DT_USER_");
            });

            modelBuilder.Entity<PreCommonDistrict>(entity =>
            {
                entity.ToTable("pre_common_district");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Upid).HasColumnName("upid");
            });

            modelBuilder.Entity<WxAgentInfo>(entity =>
            {
                entity.ToTable("wx_agent_info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ARemark)
                    .HasColumnName("aRemark")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.AgentArea)
                    .HasColumnName("agentArea")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgentLevel)
                    .HasColumnName("agentLevel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentPrice).HasColumnName("agentPrice");

                entity.Property(e => e.AgentPrice2).HasColumnName("agentPrice2");

                entity.Property(e => e.AgentType).HasColumnName("agentType");

                entity.Property(e => e.CompanyInfo)
                    .HasColumnName("companyInfo")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("companyName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CzTotMoney).HasColumnName("czTotMoney");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("expiryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.Property(e => e.RemainMony).HasColumnName("remainMony");

                entity.Property(e => e.SqJine).HasColumnName("sqJine");

                entity.Property(e => e.UserNum).HasColumnName("userNum");

                entity.Property(e => e.WcodeNum).HasColumnName("wcodeNum");
            });

            modelBuilder.Entity<WxAlbumsInfo>(entity =>
            {
                entity.ToTable("wx_albums_info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AContent)
                    .HasColumnName("aContent")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AName)
                    .HasColumnName("aName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatePerson)
                    .HasColumnName("createPerson")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacePic)
                    .HasColumnName("facePic")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsHidden).HasColumnName("isHidden");

                entity.Property(e => e.Music)
                    .HasColumnName("music")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.ShowContent).HasColumnName("showContent");

                entity.Property(e => e.ShowType).HasColumnName("showType");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxAlbumsPhoto>(entity =>
            {
                entity.ToTable("wx_albums_photo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AId).HasColumnName("aId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatePerson)
                    .HasColumnName("createPerson")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsHidden).HasColumnName("isHidden");

                entity.Property(e => e.PContent)
                    .HasColumnName("pContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PName)
                    .HasColumnName("pName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPic)
                    .HasColumnName("photoPic")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<WxAlbumsSys>(entity =>
            {
                entity.ToTable("wx_albums_sys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BannerPic)
                    .HasColumnName("bannerPic")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxAlbumsType>(entity =>
            {
                entity.ToTable("wx_albums_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BannerPic)
                    .HasColumnName("bannerPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Music)
                    .HasColumnName("music")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ShowType).HasColumnName("showType");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.TContent)
                    .HasColumnName("tContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TypeIco)
                    .HasColumnName("typeIco")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypePic)
                    .HasColumnName("typePic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxCards>(entity =>
            {
                entity.ToTable("wx_cards");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackCartoon)
                    .HasColumnName("backCartoon")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BackMusic)
                    .HasColumnName("backMusic")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.BackPic)
                    .HasColumnName("backPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonCharacter)
                    .HasColumnName("buttonCharacter")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Characters)
                    .HasColumnName("characters")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CkCount).HasColumnName("ckCount");

                entity.Property(e => e.CopyRight)
                    .HasColumnName("copyRight")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.ZfCount).HasColumnName("zfCount");
            });

            modelBuilder.Entity<WxCardsGl>(entity =>
            {
                entity.ToTable("wx_cards_gl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cardsid).HasColumnName("cardsid");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxDiancaiBlacklist>(entity =>
            {
                entity.ToTable("wx_diancai_blacklist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BlackDate)
                    .HasColumnName("blackDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BlackName)
                    .HasColumnName("blackName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid).HasColumnName("shopid");
            });

            modelBuilder.Entity<WxDiancaiCaipinCategory>(entity =>
            {
                entity.ToTable("wx_diancai_caipin_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsStart).HasColumnName("isStart");

                entity.Property(e => e.Miaoshu)
                    .HasColumnName("miaoshu")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid).HasColumnName("shopid");

                entity.Property(e => e.Sortid).HasColumnName("sortid");
            });

            modelBuilder.Entity<WxDiancaiCaipinManage>(entity =>
            {
                entity.ToTable("wx_diancai_caipin_manage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.CpName)
                    .HasColumnName("cpName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpPic)
                    .HasColumnName("cpPic")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CpPrice).HasColumnName("cpPrice");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DetailContent)
                    .HasColumnName("detailContent")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PriceUnite)
                    .HasColumnName("priceUnite")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Scan).HasColumnName("scan");

                entity.Property(e => e.Shopid).HasColumnName("shopid");

                entity.Property(e => e.Sortid).HasColumnName("sortid");

                entity.Property(e => e.ZkPrice).HasColumnName("zkPrice");
            });

            modelBuilder.Entity<WxDiancaiDesknum>(entity =>
            {
                entity.ToTable("wx_diancai_desknum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeskName)
                    .HasColumnName("deskName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsStart).HasColumnName("isStart");

                entity.Property(e => e.Shopid).HasColumnName("shopid");

                entity.Property(e => e.Sortid).HasColumnName("sortid");
            });

            modelBuilder.Entity<WxDiancaiDianyuan>(entity =>
            {
                entity.ToTable("wx_diancai_dianyuan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bianhao)
                    .HasColumnName("bianhao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DianyuanName)
                    .HasColumnName("dianyuanName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DianyuanTel)
                    .HasColumnName("dianyuanTel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fendian)
                    .HasColumnName("fendian")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(100);

                entity.Property(e => e.Shopid).HasColumnName("shopid");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatus).HasColumnName("userStatus");
            });

            modelBuilder.Entity<WxDiancaiDingdanCaiping>(entity =>
            {
                entity.ToTable("wx_diancai_dingdan_caiping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaiId).HasColumnName("caiId");

                entity.Property(e => e.DingId).HasColumnName("dingId");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Totpric).HasColumnName("totpric");
            });

            modelBuilder.Entity<WxDiancaiDingdanManage>(entity =>
            {
                entity.ToTable("wx_diancai_dingdan_manage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customerName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTel)
                    .HasColumnName("customerTel")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeskNumber)
                    .HasColumnName("deskNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OderRemark)
                    .HasColumnName("oderRemark")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OderTime)
                    .HasColumnName("oderTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("orderNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayAmount).HasColumnName("payAmount");

                entity.Property(e => e.PayStatus).HasColumnName("payStatus");

                entity.Property(e => e.Shopinfoid).HasColumnName("shopinfoid");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxDiancaiFormControl>(entity =>
            {
                entity.ToTable("wx_diancai_form_control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CType)
                    .HasColumnName("cType")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("defaultValue")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsBiTian).HasColumnName("isBiTian");

                entity.Property(e => e.IsSys).HasColumnName("isSys");

                entity.Property(e => e.MaxLength).HasColumnName("maxLength");

                entity.Property(e => e.MinLength).HasColumnName("minLength");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.ShopinfoId).HasColumnName("shopinfoId");

                entity.Property(e => e.SysControlerType)
                    .HasColumnName("sysControlerType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxDiancaiFormResult>(entity =>
            {
                entity.ToTable("wx_diancai_form_result");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cId");

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopinfoId).HasColumnName("shopinfoId");

                entity.Property(e => e.UserResult)
                    .HasColumnName("userResult")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxDiancaiMember>(entity =>
            {
                entity.ToTable("wx_diancai_member");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CancelDingdan).HasColumnName("cancelDingdan");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailDingdan).HasColumnName("failDingdan");

                entity.Property(e => e.MemberAddress)
                    .HasColumnName("memberAddress")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .HasColumnName("memberName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MenberTel)
                    .HasColumnName("menberTel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid).HasColumnName("shopid");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.SuccessDingdan).HasColumnName("successDingdan");

                entity.Property(e => e.WeixinName)
                    .HasColumnName("weixinName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Zongcje).HasColumnName("zongcje");

                entity.Property(e => e.Zongjifen).HasColumnName("zongjifen");
            });

            modelBuilder.Entity<WxDiancaiShopAdvertisement>(entity =>
            {
                entity.ToTable("wx_diancai_shop_advertisement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdvertisementName)
                    .HasColumnName("advertisementName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Isdisplay).HasColumnName("isdisplay");

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Setupid).HasColumnName("setupid");

                entity.Property(e => e.Sortid).HasColumnName("sortid");

                entity.Property(e => e.WebsetUrl)
                    .HasColumnName("websetUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxDiancaiShopSetup>(entity =>
            {
                entity.ToTable("wx_diancai_shop_setup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnionManage)
                    .HasColumnName("unionManage")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnionTel)
                    .HasColumnName("unionTel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxDiancaiShopinfo>(entity =>
            {
                entity.ToTable("wx_diancai_shopinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Css)
                    .HasColumnName("css")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DcRename)
                    .HasColumnName("dcRename")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Emailpwd)
                    .HasColumnName("emailpwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FreeSendcost).HasColumnName("freeSendcost");

                entity.Property(e => e.HotelLogo)
                    .HasColumnName("hotelLogo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .HasColumnName("hotelName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hotelintroduction)
                    .HasColumnName("hotelintroduction")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HoteltimeBegin)
                    .HasColumnName("hoteltimeBegin")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoteltimeBegin1)
                    .HasColumnName("hoteltimeBegin1")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoteltimeBegin2)
                    .HasColumnName("hoteltimeBegin2")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoteltimeEnd)
                    .HasColumnName("hoteltimeEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoteltimeEnd1)
                    .HasColumnName("hoteltimeEnd1")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoteltimeEnd2)
                    .HasColumnName("hoteltimeEnd2")
                    .HasColumnType("datetime");

                entity.Property(e => e.KcType)
                    .HasColumnName("kcType")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteOrder).HasColumnName("limiteOrder");

                entity.Property(e => e.Miaoshu)
                    .HasColumnName("miaoshu")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notice)
                    .HasColumnName("notice")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PersonLimite).HasColumnName("personLimite");

                entity.Property(e => e.Radius)
                    .HasColumnName("radius")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SendArea)
                    .HasColumnName("sendArea")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SendCost).HasColumnName("sendCost");

                entity.Property(e => e.SendPrice).HasColumnName("sendPrice");

                entity.Property(e => e.Stmp)
                    .HasColumnName("stmp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.Xplace).HasColumnName("xplace");

                entity.Property(e => e.Yplace).HasColumnName("yplace");
            });

            modelBuilder.Entity<WxDiancaiShoppic>(entity =>
            {
                entity.ToTable("wx_diancai_shoppic");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PictzUrl)
                    .HasColumnName("pictzUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid).HasColumnName("shopid");

                entity.Property(e => e.Sortid).HasColumnName("sortid");
            });

            modelBuilder.Entity<WxDzpActionInfo>(entity =>
            {
                entity.ToTable("wx_dzpActionInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AStatus).HasColumnName("aStatus");

                entity.Property(e => e.ActContent)
                    .HasColumnName("actContent")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ActName)
                    .HasColumnName("actName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeginPic)
                    .HasColumnName("beginPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cfcjhf)
                    .HasColumnName("cfcjhf")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractInfo)
                    .HasColumnName("contractInfo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayMaxTimes).HasColumnName("dayMaxTimes");

                entity.Property(e => e.DjPwd)
                    .HasColumnName("djPwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndContent)
                    .HasColumnName("endContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndNotice)
                    .HasColumnName("endNotice")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndPic)
                    .HasColumnName("endPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OpenXyj)
                    .HasColumnName("openXyj")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonMaxTimes).HasColumnName("personMaxTimes");

                entity.Property(e => e.PersonNum).HasColumnName("personNum");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxDzpAwardItem>(entity =>
            {
                entity.ToTable("wx_dzpAwardItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JiaoduMax)
                    .HasColumnName("jiaodu_max")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.JiaoduMin)
                    .HasColumnName("jiaodu_min")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JpNum).HasColumnName("jpNum");

                entity.Property(e => e.JpRealNum).HasColumnName("jpRealNum");

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");
            });

            modelBuilder.Entity<WxDzpAwardUser>(entity =>
            {
                entity.ToTable("wx_dzpAwardUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HasLingQu).HasColumnName("hasLingQu");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JxIndex)
                    .HasColumnName("jxIndex")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UTel)
                    .HasColumnName("uTel")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxDzpUsersTemp>(entity =>
            {
                entity.ToTable("wx_dzpUsersTemp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Times).HasColumnName("times");
            });

            modelBuilder.Entity<WxGgkActionInfo>(entity =>
            {
                entity.ToTable("wx_ggkActionInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActContent)
                    .HasColumnName("actContent")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ActName)
                    .HasColumnName("actName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeginPic)
                    .HasColumnName("beginPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cfcjhf)
                    .HasColumnName("cfcjhf")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractInfo)
                    .HasColumnName("contractInfo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayMaxTimes).HasColumnName("dayMaxTimes");

                entity.Property(e => e.DjPwd)
                    .HasColumnName("djPwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndContent)
                    .HasColumnName("endContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndNotice)
                    .HasColumnName("endNotice")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndPic)
                    .HasColumnName("endPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OpenXyj)
                    .HasColumnName("openXyj")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonMaxTimes).HasColumnName("personMaxTimes");

                entity.Property(e => e.PersonNum).HasColumnName("personNum");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxGgkAwardItem>(entity =>
            {
                entity.ToTable("wx_ggkAwardItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JpNum).HasColumnName("jpNum");

                entity.Property(e => e.JpRealNum).HasColumnName("jpRealNum");

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");
            });

            modelBuilder.Entity<WxGgkAwardUser>(entity =>
            {
                entity.ToTable("wx_ggkAwardUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HasLingQu).HasColumnName("hasLingQu");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UTel)
                    .HasColumnName("uTel")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxGgkUsersTemp>(entity =>
            {
                entity.ToTable("wx_ggkUsersTemp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Times).HasColumnName("times");
            });

            modelBuilder.Entity<WxLbsSetting>(entity =>
            {
                entity.ToTable("wx_lbs_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BannerPicUrl)
                    .HasColumnName("bannerPicUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SearchRadius).HasColumnName("searchRadius");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxLbsShopInfo>(entity =>
            {
                entity.ToTable("wx_lbs_shopInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DetailAddr)
                    .HasColumnName("detailAddr")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.ShopContent)
                    .HasColumnName("shopContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ShopLogo)
                    .HasColumnName("shopLogo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .HasColumnName("shopName")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WUrl)
                    .HasColumnName("wUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.XPoint).HasColumnName("xPoint");

                entity.Property(e => e.YPoint).HasColumnName("yPoint");
            });

            modelBuilder.Entity<WxLinkModule>(entity =>
            {
                entity.ToTable("wx_link_module");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdColumn)
                    .HasColumnName("idColumn")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.IsMore).HasColumnName("isMore");

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("moduleCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasColumnName("moduleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleType).HasColumnName("moduleType");

                entity.Property(e => e.NameColumn)
                    .HasColumnName("nameColumn")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sortId");

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlNeedReplace).HasColumnName("urlNeedReplace");

                entity.Property(e => e.UrlRule)
                    .HasColumnName("urlRule")
                    .HasMaxLength(1200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxLogs>(entity =>
            {
                entity.ToTable("wx_logs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatePerson)
                    .HasColumnName("createPerson")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Flg)
                    .HasColumnName("flg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Flg2)
                    .HasColumnName("flg2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Flg3)
                    .HasColumnName("flg3")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgDate)
                    .HasColumnName("flgDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgInt).HasColumnName("flgInt");

                entity.Property(e => e.FunName)
                    .HasColumnName("funName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LogsContent)
                    .HasColumnName("logsContent")
                    .HasColumnType("text");

                entity.Property(e => e.LogsTitle)
                    .HasColumnName("logsTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogsType).HasColumnName("logsType");

                entity.Property(e => e.LogsTypeName)
                    .HasColumnName("logsTypeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasColumnName("modelName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxManagerBill>(entity =>
            {
                entity.ToTable("wx_manager_bill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BillMoney).HasColumnName("billMoney");

                entity.Property(e => e.BillUsed)
                    .HasColumnName("billUsed")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.Property(e => e.MoneyType)
                    .HasColumnName("moneyType")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OperDate)
                    .HasColumnName("operDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperPersonId).HasColumnName("operPersonId");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxMessageBlacklist>(entity =>
            {
                entity.ToTable("wx_message_blacklist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Blacktime)
                    .HasColumnName("blacktime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxMessageList>(entity =>
            {
                entity.ToTable("wx_message_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HasSh).HasColumnName("hasSH");

                entity.Property(e => e.OpenId)
                    .HasColumnName("openId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxMessageSetting>(entity =>
            {
                entity.ToTable("wx_message_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminOpenid)
                    .HasColumnName("adminOpenid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NeedSh).HasColumnName("needSH");

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxModuleTemplates>(entity =>
            {
                entity.ToTable("wx_module_templates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AboutPic)
                    .HasColumnName("aboutPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DegreId).HasColumnName("degreId");

                entity.Property(e => e.DegreeName)
                    .HasColumnName("degreeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ForWxVersion)
                    .HasColumnName("forWxVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("moduleCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasColumnName("moduleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TFileName)
                    .HasColumnName("tFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TName)
                    .HasColumnName("tName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxModuleTemplatesWcode>(entity =>
            {
                entity.ToTable("wx_module_templates_wcode");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BmenuTid)
                    .HasColumnName("bmenuTid")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelTid).HasColumnName("channelTid");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DetailTid).HasColumnName("detailTid");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ListTid).HasColumnName("listTid");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.TopcolorHtml)
                    .HasColumnName("topcolorHtml")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TopcolorTypeId).HasColumnName("topcolorTypeId");

                entity.Property(e => e.TopcolorTypeName)
                    .HasColumnName("topcolorTypeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxOrderTemp>(entity =>
            {
                entity.ToTable("wx_order_temp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComplateDate)
                    .HasColumnName("complateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtFloat).HasColumnName("extFloat");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMoney).HasColumnName("orderMoney");

                entity.Property(e => e.OrderStatus).HasColumnName("orderStatus");

                entity.Property(e => e.Ordersubject)
                    .HasColumnName("ordersubject")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasColumnName("out_trade_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonNum).HasColumnName("personNum");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.Property(e => e.RoomName)
                    .HasColumnName("roomName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RtimesId).HasColumnName("rtimesId");

                entity.Property(e => e.StadId).HasColumnName("stadId");

                entity.Property(e => e.StadName)
                    .HasColumnName("stadName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TtPrice).HasColumnName("ttPrice");

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.YdBeginDate)
                    .HasColumnName("ydBeginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.YdEndDate)
                    .HasColumnName("ydEndDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WxPanoJd>(entity =>
            {
                entity.ToTable("wx_pano_jd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.JdName)
                    .HasColumnName("jdName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Music)
                    .HasColumnName("music")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.PicBehind)
                    .HasColumnName("pic_behind")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicBottom)
                    .HasColumnName("pic_bottom")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicFront)
                    .HasColumnName("pic_front")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicLeft)
                    .HasColumnName("pic_left")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicRight)
                    .HasColumnName("pic_right")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicTop)
                    .HasColumnName("pic_top")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicYulan)
                    .HasColumnName("pic_yulan")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.SysId).HasColumnName("sysId");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPanoSys>(entity =>
            {
                entity.ToTable("wx_pano_sys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackPic)
                    .HasColumnName("backPic")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.SeriesId).HasColumnName("seriesId");

                entity.Property(e => e.SeriesName)
                    .HasColumnName("seriesName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPaymentAlipay>(entity =>
            {
                entity.ToTable("wx_payment_alipay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EKey)
                    .HasColumnName("e_key")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasColumnName("ownerName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateKey)
                    .HasColumnName("private_key")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PublicKey)
                    .HasColumnName("public_key")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SignType)
                    .HasColumnName("sign_type")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPaymentType>(entity =>
            {
                entity.ToTable("wx_payment_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApiPath)
                    .HasColumnName("api_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.TypeCode)
                    .HasColumnName("typeCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxPaymentWxpay>(entity =>
            {
                entity.ToTable("wx_payment_wxpay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppId)
                    .HasColumnName("appId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bankCode")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasColumnName("bankName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CertInfoPath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartnerId)
                    .HasColumnName("partnerId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerKey)
                    .HasColumnName("partnerKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerPwd)
                    .HasColumnName("partnerPwd")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaySignKey)
                    .HasColumnName("paySignKey")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.QuicklyFh).HasColumnName("quicklyFH");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ShName)
                    .HasColumnName("shName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPicStore>(entity =>
            {
                entity.ToTable("wx_PicStore");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PicCreatePerson)
                    .HasColumnName("picCreatePerson")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PicName)
                    .HasColumnName("picName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PicTemplates)
                    .HasColumnName("picTemplates")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PicType).HasColumnName("picType");

                entity.Property(e => e.PicUri)
                    .HasColumnName("picUri")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PicUsedType)
                    .HasColumnName("picUsedType")
                    .HasMaxLength(50);

                entity.Property(e => e.PicValue)
                    .HasColumnName("picValue")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxProduct>(entity =>
            {
                entity.ToTable("wx_product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BtnName)
                    .HasColumnName("btnName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatePerson)
                    .HasColumnName("createPerson")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Daohangurl)
                    .HasColumnName("daohangurl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HdName)
                    .HasColumnName("hdName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.MaxPersonNum).HasColumnName("maxPersonNum");

                entity.Property(e => e.MinPersonNum).HasColumnName("minPersonNum");

                entity.Property(e => e.PContent)
                    .HasColumnName("pContent")
                    .HasColumnType("ntext");

                entity.Property(e => e.PSubject)
                    .HasColumnName("pSubject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PersonContent)
                    .HasColumnName("personContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ShowDate).HasColumnName("showDate");

                entity.Property(e => e.ShowPrice).HasColumnName("showPrice");

                entity.Property(e => e.ShowYuDing).HasColumnName("showYuDing");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UrlName)
                    .HasColumnName("urlName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxProductComment>(entity =>
            {
                entity.ToTable("wx_product_comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentContent)
                    .HasColumnName("commentContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommentRemark)
                    .HasColumnName("commentRemark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CommentType).HasColumnName("commentType");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HdId).HasColumnName("hdId");

                entity.Property(e => e.OpenId)
                    .HasColumnName("openId")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyContent)
                    .HasColumnName("replyContent")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyDate)
                    .HasColumnName("replyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReplyPerson)
                    .HasColumnName("replyPerson")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyStatus).HasColumnName("replyStatus");
            });

            modelBuilder.Entity<WxProductSys>(entity =>
            {
                entity.ToTable("wx_product_sys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Banner)
                    .HasColumnName("banner")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxProductType>(entity =>
            {
                entity.ToTable("wx_product_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassLayer).HasColumnName("class_layer");

                entity.Property(e => e.CreatDate)
                    .HasColumnName("creatDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Daohangurl)
                    .HasColumnName("daohangurl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IcoPic)
                    .HasColumnName("icoPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ShowDefault).HasColumnName("showDefault");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.TCode)
                    .HasColumnName("tCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TName)
                    .HasColumnName("tName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TUrl)
                    .HasColumnName("tUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPropertyInfo>(entity =>
            {
                entity.ToTable("wx_property_info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpiresIn).HasColumnName("expires_in");

                entity.Property(e => e.IContent)
                    .HasColumnName("iContent")
                    .IsUnicode(false);

                entity.Property(e => e.IName)
                    .HasColumnName("iName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPurchaseBase>(entity =>
            {
                entity.ToTable("wx_purchase_base");

                entity.Property(e => e.ActiveDescription)
                    .HasColumnName("activeDescription")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityEndtitle)
                    .HasColumnName("activityEndtitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityName)
                    .HasColumnName("activityName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivitySummary)
                    .HasColumnName("activitySummary")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTimebegin)
                    .HasColumnName("activityTimebegin")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActivityTimeend)
                    .HasColumnName("activityTimeend")
                    .HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CopyrightSetup)
                    .HasColumnName("copyrightSetup")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnName("costPrice");

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPwd)
                    .HasColumnName("emailPwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndExplanation)
                    .HasColumnName("endExplanation")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.GoodName)
                    .HasColumnName("goodName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupPerson).HasColumnName("groupPerson");

                entity.Property(e => e.GroupPrice).HasColumnName("groupPrice");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("imageUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.ImageUrlend)
                    .HasColumnName("imageUrlend")
                    .HasMaxLength(200);

                entity.Property(e => e.Introduction)
                    .HasColumnName("introduction")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LimitCount).HasColumnName("limitCount");

                entity.Property(e => e.ShopsPwd)
                    .HasColumnName("shopsPwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shopstel)
                    .HasColumnName("shopstel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Smtp)
                    .HasColumnName("smtp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialRemind)
                    .HasColumnName("specialRemind")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCount).HasColumnName("totalCount");

                entity.Property(e => e.TxtLatXpoint).HasColumnName("txtLatXPoint");

                entity.Property(e => e.TxtLngYpoint).HasColumnName("txtLngYPoint");

                entity.Property(e => e.VirtualPerson).HasColumnName("virtualPerson");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxPurchaseCustomer>(entity =>
            {
                entity.ToTable("wx_purchase_customer");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Baseid).HasColumnName("baseid");

                entity.Property(e => e.CraeteTime)
                    .HasColumnName("craeteTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customerName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNum).HasColumnName("customerNum");

                entity.Property(e => e.DateJoin)
                    .HasColumnName("dateJoin")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUse)
                    .HasColumnName("dateUse")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxRequestRule>(entity =>
            {
                entity.ToTable("wx_requestRule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentToken)
                    .HasColumnName("agentToken")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AgentUrl)
                    .HasColumnName("agentUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtInt2).HasColumnName("extInt2");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr4)
                    .HasColumnName("extStr4")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault)
                    .HasColumnName("isDefault")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLikeSearch)
                    .HasColumnName("isLikeSearch")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFunctionId).HasColumnName("modelFunctionId");

                entity.Property(e => e.ModelFunctionName)
                    .HasColumnName("modelFunctionName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReqKeywords)
                    .HasColumnName("reqKeywords")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ReqestType).HasColumnName("reqestType");

                entity.Property(e => e.ResponseType).HasColumnName("responseType");

                entity.Property(e => e.RuleName)
                    .HasColumnName("ruleName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.UId).HasColumnName("uId");

                entity.Property(e => e.WId).HasColumnName("wId");
            });

            modelBuilder.Entity<WxRequestRuleContent>(entity =>
            {
                entity.ToTable("wx_requestRuleContent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DetailUrl)
                    .HasColumnName("detailUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtInt2).HasColumnName("extInt2");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Extstr3)
                    .HasColumnName("extstr3")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.MediaUrl)
                    .HasColumnName("mediaUrl")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.MeidaHdurl)
                    .HasColumnName("meidaHDUrl")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RContent)
                    .HasColumnName("rContent")
                    .HasColumnType("text");

                entity.Property(e => e.RContent2)
                    .HasColumnName("rContent2")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RId).HasColumnName("rId");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.UId).HasColumnName("uId");
            });

            modelBuilder.Entity<WxRequstBaseData>(entity =>
            {
                entity.ToTable("wx_requst_BaseData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.RType)
                    .HasColumnName("rType")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.WxCreateTime)
                    .HasColumnName("wx_createTime")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.WxDataContent)
                    .HasColumnName("wx_dataContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.WxEventKey)
                    .HasColumnName("wx_eventKey")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WxMsgType)
                    .HasColumnName("wx_msgType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WxOpenid)
                    .HasColumnName("wx_openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WxUrl)
                    .HasColumnName("wx_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WxUrl2)
                    .HasColumnName("wx_url2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WxXmlContent)
                    .HasColumnName("wx_xmlContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxResponseBaseData>(entity =>
            {
                entity.ToTable("wx_response_BaseData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.RType)
                    .HasColumnName("rType")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReponseContent)
                    .HasColumnName("reponseContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestContent)
                    .HasColumnName("requestContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType)
                    .HasColumnName("requestType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseType)
                    .HasColumnName("responseType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.WxOpenid)
                    .HasColumnName("wx_openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WxXmlContent)
                    .HasColumnName("wx_xmlContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxSTicket>(entity =>
            {
                entity.ToTable("wx_sTicket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AContent)
                    .HasColumnName("aContent")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ActionName)
                    .HasColumnName("actionName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BannerPic)
                    .HasColumnName("bannerPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeginPic)
                    .HasColumnName("beginPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndContent)
                    .HasColumnName("endContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndNotice)
                    .HasColumnName("endNotice")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndPic)
                    .HasColumnName("endPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.SuccTip)
                    .HasColumnName("succTip")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsedRemark)
                    .HasColumnName("usedRemark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WUrl)
                    .HasColumnName("wUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopAlbums>(entity =>
            {
                entity.ToTable("wx_shop_albums");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriginalPath)
                    .HasColumnName("original_path")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbPath)
                    .HasColumnName("thumb_path")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopBrand>(entity =>
            {
                entity.ToTable("wx_shop_brand");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BName)
                    .HasColumnName("bName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("companyName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasColumnName("companyUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopCart>(entity =>
            {
                entity.ToTable("wx_shop_cart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ProductNum).HasColumnName("productNum");

                entity.Property(e => e.SkuId).HasColumnName("skuId");

                entity.Property(e => e.SkuInfo)
                    .IsRequired()
                    .HasColumnName("skuInfo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotPrice).HasColumnName("totPrice");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopCatalog>(entity =>
            {
                entity.ToTable("wx_shop_catalog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CTitle)
                    .HasColumnName("cTitle")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopCatalogAttribute>(entity =>
            {
                entity.ToTable("wx_shop_catalog_attribute");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AName)
                    .HasColumnName("aName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AType).HasColumnName("aType");

                entity.Property(e => e.AValue)
                    .HasColumnName("aValue")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogId).HasColumnName("catalogId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopCategory>(entity =>
            {
                entity.ToTable("wx_shop_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassContent)
                    .HasColumnName("class_content")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ClassLayer).HasColumnName("class_layer");

                entity.Property(e => e.ClassList)
                    .HasColumnName("class_list")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IcoUrl)
                    .HasColumnName("ico_url")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("link_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopCategoryCatalog>(entity =>
            {
                entity.ToTable("wx_shop_category_catalog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatalogId).HasColumnName("catalogId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            });

            modelBuilder.Entity<WxShopComment>(entity =>
            {
                entity.ToTable("wx_shop_comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("add_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CContent)
                    .HasColumnName("cContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.IsReply).HasColumnName("is_reply");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ReplyContent)
                    .HasColumnName("reply_content")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyTime)
                    .HasColumnName("reply_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxShopProduct>(entity =>
            {
                entity.ToTable("wx_shop_product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddDate)
                    .HasColumnName("addDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.Property(e => e.CatalogId).HasColumnName("catalogId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CostPrice).HasColumnName("costPrice");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryEndDate).HasColumnType("datetime");

                entity.Property(e => e.FocusImgUrl)
                    .HasColumnName("focusImgUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Hotsale).HasColumnName("hotsale");

                entity.Property(e => e.Latest).HasColumnName("latest");

                entity.Property(e => e.MarketPrice).HasColumnName("marketPrice");

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionDate)
                    .HasColumnName("productionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recommended).HasColumnName("recommended");

                entity.Property(e => e.SalePrice).HasColumnName("salePrice");

                entity.Property(e => e.SeoDescription)
                    .HasColumnName("seo_description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDesc)
                    .HasColumnName("shortDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.SpecialOffer).HasColumnName("specialOffer");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.ThumbnailsUrll)
                    .HasColumnName("thumbnailsUrll")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upselling).HasColumnName("upselling");

                entity.Property(e => e.VistiCounts).HasColumnName("vistiCounts");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopProductAttrValue>(entity =>
            {
                entity.ToTable("wx_shop_productAttr_value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttributeId).HasColumnName("attributeId");

                entity.Property(e => e.PaValue)
                    .HasColumnName("paValue")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("productId");
            });

            modelBuilder.Entity<WxShopSetting>(entity =>
            {
                entity.ToTable("wx_shop_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BgPic)
                    .HasColumnName("bgPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Copyright)
                    .HasColumnName("copyright")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .HasColumnName("shopName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxShopSku>(entity =>
            {
                entity.ToTable("wx_shop_sku");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttributeId).HasColumnName("attributeId");

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attributeValue")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<WxShopUserAddr>(entity =>
            {
                entity.ToTable("wx_shop_user_addr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddrDetail)
                    .HasColumnName("addrDetail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractPerson)
                    .HasColumnName("contractPerson")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.Jiedao)
                    .HasColumnName("jiedao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .IsRequired()
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSjbBisai>(entity =>
            {
                entity.ToTable("wx_sjb_bisai");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BsPic)
                    .HasColumnName("bsPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.BsRemark)
                    .HasColumnName("bsRemark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JcBeginDate)
                    .HasColumnName("jcBeginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JcEndDate)
                    .HasColumnName("jcEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qd1Id).HasColumnName("qd1Id");

                entity.Property(e => e.Qd2Id).HasColumnName("qd2Id");

                entity.Property(e => e.RType1Times).HasColumnName("rType1Times");

                entity.Property(e => e.RType2Times).HasColumnName("rType2Times");

                entity.Property(e => e.RType3Times).HasColumnName("rType3Times");

                entity.Property(e => e.RcId).HasColumnName("rcId");

                entity.Property(e => e.ResultType).HasColumnName("resultType");
            });

            modelBuilder.Entity<WxSjbJcDetail>(entity =>
            {
                entity.ToTable("wx_sjb_jcDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BsId).HasColumnName("bsId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JcRetType).HasColumnName("jcRetType");

                entity.Property(e => e.RcId).HasColumnName("rcId");

                entity.Property(e => e.RetIsRight).HasColumnName("retIsRight");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<WxSjbQiudui>(entity =>
            {
                entity.ToTable("wx_sjb_qiudui");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailTimes).HasColumnName("failTimes");

                entity.Property(e => e.QdName)
                    .HasColumnName("qdName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QdPic)
                    .HasColumnName("qdPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.SuccTimes).HasColumnName("succTimes");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSjbRicheng>(entity =>
            {
                entity.ToTable("wx_sjb_richeng");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RcName)
                    .HasColumnName("rcName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RcPic)
                    .HasColumnName("rcPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSjbUsers>(entity =>
            {
                entity.ToTable("wx_sjb_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FailTimes).HasColumnName("failTimes");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SuccTimes).HasColumnName("succTimes");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSmallLink>(entity =>
            {
                entity.ToTable("wx_small_link");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComTel)
                    .HasColumnName("comTel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("companyName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasColumnName("sType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sortId");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxSmsConfig>(entity =>
            {
                entity.ToTable("wx_sms_config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qianming)
                    .IsRequired()
                    .HasColumnName("qianming")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sortId");

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ucode)
                    .IsRequired()
                    .HasColumnName("ucode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSmsInfo>(entity =>
            {
                entity.ToTable("wx_sms_info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionId).HasColumnName("actionId");

                entity.Property(e => e.ActionName)
                    .HasColumnName("actionName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("moduleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStatusNum)
                    .HasColumnName("sStatusNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmsContent)
                    .HasColumnName("smsContent")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSqAct>(entity =>
            {
                entity.ToTable("wx_sq_act");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActName)
                    .HasColumnName("actName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BannerPic)
                    .HasColumnName("bannerPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.NoshengheTip)
                    .HasColumnName("noshengheTip")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Shenghe).HasColumnName("shenghe");

                entity.Property(e => e.ShengheTip)
                    .HasColumnName("shengheTip")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxSqHeimd>(entity =>
            {
                entity.ToTable("wx_sq_heimd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxSqPiclist>(entity =>
            {
                entity.ToTable("wx_sq_piclist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HasShenghe).HasColumnName("hasShenghe");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxSttAwardItem>(entity =>
            {
                entity.ToTable("wx_sttAwardItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JpNum).HasColumnName("jpNum");

                entity.Property(e => e.JpRealNum).HasColumnName("jpRealNum");

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");
            });

            modelBuilder.Entity<WxSttAwardUser>(entity =>
            {
                entity.ToTable("wx_sttAwardUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HasLingQu).HasColumnName("hasLingQu");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UTel)
                    .HasColumnName("uTel")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxSysConfig>(entity =>
            {
                entity.ToTable("wx_sysConfig");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.SysCode)
                    .HasColumnName("sysCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysName)
                    .HasColumnName("sysName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SysTypeId).HasColumnName("sysTypeId");

                entity.Property(e => e.SysTypeName)
                    .HasColumnName("sysTypeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysValue)
                    .HasColumnName("sysValue")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxTemplates>(entity =>
            {
                entity.ToTable("wx_templates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AboutPic)
                    .HasColumnName("aboutPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DegreId).HasColumnName("degreId");

                entity.Property(e => e.DegreeName)
                    .HasColumnName("degreeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ForWxVersion)
                    .HasColumnName("forWxVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TFileName)
                    .HasColumnName("tFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TName)
                    .HasColumnName("tName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxTemplatesWcode>(entity =>
            {
                entity.ToTable("wx_templates_wcode");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BmenuTid).HasColumnName("bmenuTid");

                entity.Property(e => e.ChannelTid).HasColumnName("channelTid");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DetailTid).HasColumnName("detailTid");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ListTid).HasColumnName("listTid");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.TopcolorHtml)
                    .HasColumnName("topcolorHtml")
                    .HasColumnType("text");

                entity.Property(e => e.TopcolorTypeId).HasColumnName("topcolorTypeId");

                entity.Property(e => e.TopcolorTypeName)
                    .HasColumnName("topcolorTypeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardAdver>(entity =>
            {
                entity.ToTable("wx_ucard_adver");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdverName)
                    .HasColumnName("adverName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsShow).HasColumnName("isShow");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("linkUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardCardinfo>(entity =>
            {
                entity.ToTable("wx_ucard_cardinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BgTypeId).HasColumnName("bgTypeId");

                entity.Property(e => e.BgTypeUrl)
                    .HasColumnName("bgTypeUrl")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BgUrl)
                    .HasColumnName("bgUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasColumnName("cardName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardNameColor)
                    .HasColumnName("cardNameColor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNoColor)
                    .HasColumnName("cardNoColor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactusPic)
                    .HasColumnName("contactusPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IndexTip)
                    .HasColumnName("indexTip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InstructionsPic)
                    .HasColumnName("instructionsPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsLogoShow).HasColumnName("isLogoShow");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.NoticePic)
                    .HasColumnName("noticePic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerinfoPic)
                    .HasColumnName("perinfoPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrivilegesPic)
                    .HasColumnName("privilegesPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QiandaoPic)
                    .HasColumnName("qiandaoPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.ShopingPic)
                    .HasColumnName("shopingPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardGift>(entity =>
            {
                entity.ToTable("wx_ucard_gift");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GName)
                    .HasColumnName("gName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.UseContent)
                    .HasColumnName("useContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardNotice>(entity =>
            {
                entity.ToTable("wx_ucard_notice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NContent)
                    .HasColumnName("nContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.NName)
                    .HasColumnName("nName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.UserDegree)
                    .HasColumnName("userDegree")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardPrivileges>(entity =>
            {
                entity.ToTable("wx_ucard_privileges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PName)
                    .HasColumnName("pName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.UsedContent)
                    .HasColumnName("usedContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.UserDegree)
                    .HasColumnName("userDegree")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardScore>(entity =>
            {
                entity.ToTable("wx_ucard_score");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsumeMoney).HasColumnName("consumeMoney");

                entity.Property(e => e.ConsumeMoneyScore).HasColumnName("consumeMoneyScore");

                entity.Property(e => e.Qiandao6Score).HasColumnName("qiandao6Score");

                entity.Property(e => e.QiandaoScore).HasColumnName("qiandaoScore");

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.ScoreRegular)
                    .HasColumnName("scoreRegular")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.UserdContent)
                    .HasColumnName("userdContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardStore>(entity =>
            {
                entity.ToTable("wx_ucard_store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CardBrief)
                    .HasColumnName("cardBrief")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumePwd)
                    .HasColumnName("consumePwd")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HfPic)
                    .HasColumnName("hfPic")
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.IsRecommend).HasColumnName("isRecommend");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.StoreCatagory)
                    .HasColumnName("storeCatagory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasColumnName("storeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.XPoint).HasColumnName("xPoint");

                entity.Property(e => e.YPoint).HasColumnName("yPoint");
            });

            modelBuilder.Entity<WxUcardStoreFendian>(entity =>
            {
                entity.ToTable("wx_ucard_store_fendian");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XPoint).HasColumnName("xPoint");

                entity.Property(e => e.YPoint).HasColumnName("yPoint");
            });

            modelBuilder.Entity<WxUcardSys>(entity =>
            {
                entity.ToTable("wx_ucard_sys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardType).HasColumnName("cardType");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TradeContent)
                    .HasColumnName("tradeContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.TradeTel)
                    .HasColumnName("tradeTel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardTicket>(entity =>
            {
                entity.ToTable("wx_ucard_ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConsumeMoney).HasColumnName("consumeMoney");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DyMoney).HasColumnName("dyMoney");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.SortId)
                    .HasColumnName("sort_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TName)
                    .HasColumnName("tName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.UsedContent)
                    .HasColumnName("usedContent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.UsedTimes).HasColumnName("usedTimes");

                entity.Property(e => e.UserDegree)
                    .HasColumnName("userDegree")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserType).HasColumnName("userType");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardUdegree>(entity =>
            {
                entity.ToTable("wx_ucard_udegree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallName)
                    .HasColumnName("callName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DegreeNum).HasColumnName("degreeNum");

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.ScoreMax).HasColumnName("score_max");

                entity.Property(e => e.ScoreMin).HasColumnName("score_min");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUcardUsercard>(entity =>
            {
                entity.ToTable("wx_ucard_usercard");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate)
                    .HasColumnName("addDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<WxUcardUsers>(entity =>
            {
                entity.ToTable("wx_ucard_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasColumnName("cardNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumeMoney).HasColumnName("consumeMoney");

                entity.Property(e => e.ConsumeScore).HasColumnName("consumeScore");

                entity.Property(e => e.DegreeId).HasColumnName("degreeId");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QdScore).HasColumnName("qdScore");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .HasColumnName("realName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegIp)
                    .HasColumnName("regIp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegTime)
                    .HasColumnName("regTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Telphone)
                    .HasColumnName("telphone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TtScore).HasColumnName("ttScore");

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.WxName)
                    .HasColumnName("wxName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxUcardUsersConsumeinfo>(entity =>
            {
                entity.ToTable("wx_ucard_users_consumeinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("addTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CContent)
                    .HasColumnName("cContent")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CMoneyType).HasColumnName("cMoneyType");

                entity.Property(e => e.CScoreType).HasColumnName("cScoreType");

                entity.Property(e => e.ConsumeMoney).HasColumnName("consumeMoney");

                entity.Property(e => e.ModuleActionId).HasColumnName("moduleActionId");

                entity.Property(e => e.ModuleActionName)
                    .HasColumnName("moduleActionName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleType)
                    .HasColumnName("moduleType")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleTypeId).HasColumnName("moduleTypeId");

                entity.Property(e => e.OperName)
                    .HasColumnName("operName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SId).HasColumnName("sId");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<WxUserGroup>(entity =>
            {
                entity.ToTable("wx_UserGroup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Classname)
                    .HasColumnName("classname")
                    .HasMaxLength(50);

                entity.Property(e => e.ExStr)
                    .HasColumnName("exStr")
                    .HasMaxLength(100);

                entity.Property(e => e.Gid)
                    .HasColumnName("gid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(100);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUserinfo>(entity =>
            {
                entity.ToTable("wx_Userinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr1)
                    .HasColumnName("extStr1")
                    .HasMaxLength(100);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(100);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(100);

                entity.Property(e => e.Gid)
                    .HasColumnName("gid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(100);

                entity.Property(e => e.Headimgul)
                    .HasColumnName("headimgul")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(50);

                entity.Property(e => e.Openid)
                    .IsRequired()
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Subscribe)
                    .HasColumnName("subscribe")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubscribeTime)
                    .HasColumnName("subscribe_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnsubscribeTime)
                    .HasColumnName("unsubscribe_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxUserweixin>(entity =>
            {
                entity.ToTable("wx_userweixin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("Access_Token")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Apiurl)
                    .HasColumnName("apiurl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AppId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDate)
                    .HasColumnName("deleteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtInt2).HasColumnName("extInt2");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Headerpic)
                    .HasColumnName("headerpic")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.OpenIdStr)
                    .HasColumnName("openIdStr")
                    .HasColumnType("text");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.RequestTtnum)
                    .HasColumnName("requestTTNum")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.RequestUsedNum)
                    .HasColumnName("requestUsedNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.SmsTtnum)
                    .HasColumnName("smsTTNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SmsUsedNum)
                    .HasColumnName("smsUsedNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuwenDefineNum)
                    .HasColumnName("tuwenDefineNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuwenMaxNum)
                    .HasColumnName("tuwenMaxNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UId).HasColumnName("uId");

                entity.Property(e => e.WeixinCode)
                    .HasColumnName("weixinCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WenziDefineNum)
                    .HasColumnName("wenziDefineNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WenziMaxNum)
                    .HasColumnName("wenziMaxNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WxCity)
                    .HasColumnName("wxCity")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WxId)
                    .HasColumnName("wxId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WxName)
                    .HasColumnName("wxName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WxProvince)
                    .HasColumnName("wxProvince")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WxPwd)
                    .HasColumnName("wxPwd")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WxToken)
                    .HasColumnName("wxToken")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.WxType).HasColumnName("wxType");

                entity.Property(e => e.YixinId)
                    .HasColumnName("yixinId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YuyinDefineNum)
                    .HasColumnName("yuyinDefineNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YuyinMaxNum)
                    .HasColumnName("yuyinMaxNum")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WxVoteBase>(entity =>
            {
                entity.ToTable("wx_vote_base");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActUrl)
                    .HasColumnName("actUrl")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.BeginTime)
                    .HasColumnName("beginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatDate)
                    .HasColumnName("creatDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRadio).HasColumnName("isRadio");

                entity.Property(e => e.Picdisplay).HasColumnName("picdisplay");

                entity.Property(e => e.ResultShowtype).HasColumnName("resultShowtype");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.VoteType).HasColumnName("voteType");

                entity.Property(e => e.Votecontent)
                    .HasColumnName("votecontent")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Votepic)
                    .HasColumnName("votepic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxVoteItem>(entity =>
            {
                entity.ToTable("wx_vote_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baseid).HasColumnName("baseid");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PicJump)
                    .HasColumnName("pic_jump")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("pic_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TpTimes).HasColumnName("tpTimes");
            });

            modelBuilder.Entity<WxVoteResult>(entity =>
            {
                entity.ToTable("wx_vote_result");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baseid).HasColumnName("baseid");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.OpenId)
                    .HasColumnName("openId")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxWifi>(entity =>
            {
                entity.ToTable("wx_wifi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Appkey)
                    .HasColumnName("appkey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExtSt2)
                    .HasColumnName("extSt2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr3)
                    .HasColumnName("extStr3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasColumnName("merchantId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxWsiteModulebase>(entity =>
            {
                entity.ToTable("wx_wsite_modulebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MCode)
                    .HasColumnName("mCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MName)
                    .HasColumnName("mName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MType)
                    .HasColumnName("mType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MTypeName)
                    .HasColumnName("mTypeName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MValue)
                    .HasColumnName("mValue")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MValueInt).HasColumnName("mValueInt");

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(1000);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<WxWsiteSetting>(entity =>
            {
                entity.ToTable("wx_wsite_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AddrUrl)
                    .HasColumnName("addrUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BgDongHuaId).HasColumnName("bgDongHuaId");

                entity.Property(e => e.BgMusic)
                    .HasColumnName("bgMusic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.BgPic)
                    .HasColumnName("bgPic")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("companyName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SeoDesc)
                    .HasColumnName("seo_desc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SeoKeywords)
                    .HasColumnName("seo_keywords")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SeoTitle)
                    .HasColumnName("seo_title")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WBrief)
                    .HasColumnName("wBrief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WCopyright)
                    .HasColumnName("wCopyright")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WId).HasColumnName("wId");

                entity.Property(e => e.WName)
                    .HasColumnName("wName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxXtBase>(entity =>
            {
                entity.ToTable("wx_xt_base");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Copyrite)
                    .HasColumnName("copyrite")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Donghua)
                    .HasColumnName("donghua")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DonghuaSlt)
                    .HasColumnName("donghuaSlt")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FelmanName)
                    .HasColumnName("felmanName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fengmian)
                    .HasColumnName("fengmian")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LatY).HasColumnName("latY");

                entity.Property(e => e.LngX).HasColumnName("lngX");

                entity.Property(e => e.ManName)
                    .HasColumnName("manName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Music)
                    .HasColumnName("music")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NameSeq).HasColumnName("nameSeq");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sqrurl)
                    .HasColumnName("sqrurl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Statedate)
                    .HasColumnName("statedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("templateId");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("templateName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Video2)
                    .HasColumnName("video2")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");

                entity.Property(e => e.Word)
                    .HasColumnName("word")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WxTitle)
                    .HasColumnName("wxTitle")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxXtPhoto>(entity =>
            {
                entity.ToTable("wx_xt_photo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BId).HasColumnName("bId");

                entity.Property(e => e.PName)
                    .HasColumnName("pName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PUrl)
                    .HasColumnName("pUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<WxXtUser>(entity =>
            {
                entity.ToTable("wx_xt_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BId).HasColumnName("bId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PNum).HasColumnName("pNum");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxXtZhufu>(entity =>
            {
                entity.ToTable("wx_xt_zhufu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BId).HasColumnName("bId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxYyBase>(entity =>
            {
                entity.ToTable("wx_yy_base");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExtStr2)
                    .HasColumnName("extStr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.KfName)
                    .HasColumnName("kfName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NeedSms).HasColumnName("needSMS");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PicUrl)
                    .HasColumnName("picUrl")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxYyControl>(entity =>
            {
                entity.ToTable("wx_yy_control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CType)
                    .HasColumnName("cType")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("defaultValue")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInt).HasColumnName("extInt");

                entity.Property(e => e.ExtStr)
                    .HasColumnName("extStr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("formId");

                entity.Property(e => e.IsBiTian).HasColumnName("isBiTian");

                entity.Property(e => e.IsSys).HasColumnName("isSys");

                entity.Property(e => e.MaxLength).HasColumnName("maxLength");

                entity.Property(e => e.MinLength).HasColumnName("minLength");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.SysControlerType)
                    .HasColumnName("sysControlerType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxYyResult>(entity =>
            {
                entity.ToTable("wx_yy_result");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cId");

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("formId");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserResult)
                    .HasColumnName("userResult")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxYyyActionInfo>(entity =>
            {
                entity.ToTable("wx_yyyActionInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AStatus).HasColumnName("aStatus");

                entity.Property(e => e.ActContent)
                    .HasColumnName("actContent")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ActName)
                    .HasColumnName("actName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("beginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeginPic)
                    .HasColumnName("beginPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Brief)
                    .HasColumnName("brief")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cfcjhf)
                    .HasColumnName("cfcjhf")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractInfo)
                    .HasColumnName("contractInfo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayMaxTimes).HasColumnName("dayMaxTimes");

                entity.Property(e => e.DjPwd)
                    .HasColumnName("djPwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndContent)
                    .HasColumnName("endContent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndNotice)
                    .HasColumnName("endNotice")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndPic)
                    .HasColumnName("endPic")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OpenXyj)
                    .HasColumnName("openXyj")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonMaxTimes).HasColumnName("personMaxTimes");

                entity.Property(e => e.PersonNum).HasColumnName("personNum");

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<WxYyyAwardItem>(entity =>
            {
                entity.ToTable("wx_yyyAwardItem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JiaoduMax).HasColumnName("jiaodu_max");

                entity.Property(e => e.JiaoduMin).HasColumnName("jiaodu_min");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JpNum).HasColumnName("jpNum");

                entity.Property(e => e.JpRealNum).HasColumnName("jpRealNum");

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortId).HasColumnName("sort_id");
            });

            modelBuilder.Entity<WxYyyAwardUser>(entity =>
            {
                entity.ToTable("wx_yyyAwardUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HasLingQu).HasColumnName("hasLingQu");

                entity.Property(e => e.JpName)
                    .HasColumnName("jpName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JxIndex)
                    .HasColumnName("jxIndex")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.JxName)
                    .HasColumnName("jxName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UName)
                    .HasColumnName("uName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UTel)
                    .HasColumnName("uTel")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WxYyyUsersTemp>(entity =>
            {
                entity.ToTable("wx_yyyUsersTemp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActId).HasColumnName("actId");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Times).HasColumnName("times");
            });
        }
    }
}
