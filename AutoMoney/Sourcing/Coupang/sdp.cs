using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMoney.Sourcing.Coupang
{
    public class SDP
    {
        public class Abflags
        {
            public string beautyLuxuryABTest { get; set; }
            public string applyStrikeCompanyNotice { get; set; }
            public string applyPricePolicy { get; set; }
        }
        public Abflags abFlags { get; set; }
        public object accountType { get; set; }
        public bool adult { get; set; }
        public object adultWarning { get; set; }
        public bool almostSoldOut { get; set; }
        public class Apiurlmap
        {
            public string addToCartUrl { get; set; }
            public object shippingConsolidationUrl { get; set; }
        }
        public Apiurlmap apiUrlMap { get; set; }
        public object authors { get; set; }
        public class Badgemap
        {
            public class OFFER_BADGE_
            {
                public string helpLink { get; set; }
                public object iconUrl { get; set; }
                public object text { get; set; }
                public string type { get; set; }
            }
            public OFFER_BADGE_ OFFER_BADGE { get; set; }
        }
        public Badgemap badgeMap { get; set; }
        public object betterOffer { get; set; }
        public object bizBadge { get; set; }
        public object blockInfo { get; set; }
        public string brand { get; set; }
        public class Bundleoption
        {
            public object optionDetails { get; set; }
            public object[] options { get; set; }
            public object viewType { get; set; }
        }
        public Bundleoption bundleOption { get; set; }
        public int buyableQuantity { get; set; }
        public class Cashbacksummary
        {
            public class Basiccashbacklist
            {
                public int amount { get; set; }
                public string benefit { get; set; }
                public bool expired { get; set; }
                public class I18namount
                {
                    public int amount { get; set; }
                    public string currency { get; set; }
                    public int fractionDigits { get; set; }
                    public int rawAmount { get; set; }
                }
                public I18namount i18nAmount { get; set; }
                public object leftDays { get; set; }
                public string rate { get; set; }
                public string type { get; set; }
                public string validity { get; set; }
            }
            public Basiccashbacklist[] basicCashBackList { get; set; }
            public int basicRocketPayCashAmt { get; set; }
            public string basicRocketPayRate { get; set; }
            public string cashBackTitle { get; set; }
            public string cashIconUrl { get; set; }
            public string cashWidgetIconUrl { get; set; }
            public object clubMemberCashAmt { get; set; }
            public object clubMemberRate { get; set; }
            public object clubMemberRewardExpires { get; set; }
            public object clubMemberRewardExpiryTime { get; set; }
            public object clubMemberRewardLeftDays { get; set; }
            public int couPayBankAmt { get; set; }
            public bool couPayBankExpires { get; set; }
            public int couPayBankLeftDays { get; set; }
            public string couPayBankRate { get; set; }
            public int couPayMoneyAmt { get; set; }
            public bool couPayMoneyExpires { get; set; }
            public int couPayMoneyLeftDays { get; set; }
            public string couPayMoneyRate { get; set; }
            public class Extracashbacklist
            {
                public int amount { get; set; }
                public string benefit { get; set; }
                public bool expired { get; set; }
                public class I18namount
                {
                    public int amount { get; set; }
                    public string currency { get; set; }
                    public int fractionDigits { get; set; }
                    public int rawAmount { get; set; }
                }
                public I18namount i18nAmount { get; set; }
                public int leftDays { get; set; }
                public string rate { get; set; }
                public string type { get; set; }
                public string validity { get; set; }
            }
            public Extracashbacklist[] extraCashBackList { get; set; }
            public int finalCashBackAmt { get; set; }
            public class I18nbasicrocketpaycashamt
            {
                public int amount { get; set; }
                public string currency { get; set; }
                public int fractionDigits { get; set; }
                public int rawAmount { get; set; }
            }
            public I18nbasicrocketpaycashamt i18nBasicRocketPayCashAmt { get; set; }
            public object i18nClubMemberCashAmt { get; set; }
            public class I18ncoupaybankamt
            {
                public int amount { get; set; }
                public string currency { get; set; }
                public int fractionDigits { get; set; }
                public int rawAmount { get; set; }
            }
            public I18ncoupaybankamt i18nCouPayBankAmt { get; set; }
            public class I18ncoupaymoneyamt
            {
                public int amount { get; set; }
                public string currency { get; set; }
                public int fractionDigits { get; set; }
                public int rawAmount { get; set; }
            }
            public I18ncoupaymoneyamt i18nCouPayMoneyAmt { get; set; }
            public class I18nfinalcashbackamt
            {
                public int amount { get; set; }
                public string currency { get; set; }
                public int fractionDigits { get; set; }
                public int rawAmount { get; set; }
            }
            public I18nfinalcashbackamt i18nFinalCashBackAmt { get; set; }
            public object targetedPromotionBanner { get; set; }
        }
        public Cashbacksummary cashBackSummary { get; set; }
        public bool ccidEligible { get; set; }
        public object ccidInfo { get; set; }
        public object[] couponList { get; set; }
        public bool dawnOnly { get; set; }
        public bool deliveryAttribute { get; set; }
        public object detailProductType { get; set; }
        public bool freshEligible { get; set; }
        public bool giftcard { get; set; }
        public bool hasBrandShop { get; set; }
        public class Image
        {
            public string detailImage { get; set; }
            public string origin { get; set; }
            public string preloadImage { get; set; }
            public string thumbnailImage { get; set; }
        }
        public Image[] images { get; set; }
        public bool invalid { get; set; }
        public object inventory { get; set; }
        public string itemId { get; set; }
        public string itemName { get; set; }
        public class Leafcategoryinfo
        {
            public int categoryId { get; set; }
            public object componentId { get; set; }
            public string name { get; set; }
            public string[] parentsCategoryNames { get; set; }
        }
        public Leafcategoryinfo leafCategoryInfo { get; set; }
        public object limitNoticeVo { get; set; }
        public object linkedVendorItemInfo { get; set; }
        public class Memberinfo
        {
            public bool eligibleAddress { get; set; }
            public bool loyaltyMember { get; set; }
            public bool loyaltyMemberExcludePseudoMember { get; set; }
            public object memberName { get; set; }
            public bool pseudoMember { get; set; }
            public bool withdraw { get; set; }
        }
        public Memberinfo memberInfo { get; set; }
        public object offerBanner { get; set; }
        public string offerDescription { get; set; }
        public class Options
        {
            public object attributeVendorItemMap { get; set; }
            public class Optionrow
            {
                public class Attribute
                {
                    public object bundleOptionMsg { get; set; }
                    public class Image
                    {
                        public string detailImage { get; set; }
                        public string origin { get; set; }
                        public string preloadImage { get; set; }
                        public string thumbnailImage { get; set; }
                    }
                    public Image image { get; set; }
                    public string name { get; set; }
                    public bool selected { get; set; }
                    public string valueId { get; set; }
                }
                public Attribute[] attributes { get; set; }
                public bool colorAttribute { get; set; }
                public bool deliveryAttribute { get; set; }
                public string displayComponentType { get; set; }
                public string displayType { get; set; }
                public bool leaf { get; set; }
                public string name { get; set; }
                public class Selectedattribute
                {
                    public object bundleOptionMsg { get; set; }
                    public class Image
                    {
                        public string detailImage { get; set; }
                        public string origin { get; set; }
                        public string preloadImage { get; set; }
                        public string thumbnailImage { get; set; }
                    }
                    public Image image { get; set; }
                    public string name { get; set; }
                    public bool selected { get; set; }
                    public string valueId { get; set; }
                }
                public Selectedattribute selectedAttribute { get; set; }
                public bool sizeAttribute { get; set; }
                public string typeId { get; set; }
            }
            public Optionrow[] optionRows { get; set; }
        }
        public Options options { get; set; }
        public object otherSellerCount { get; set; }
        public object preOrderVo { get; set; }
        public long productId { get; set; }
        public bool purchaseOnly { get; set; }
        public class Quantitybase
        {
            public object appliedCoupon { get; set; }
            public object benefitDisplayType { get; set; }
            public object bundleOption { get; set; }
            public object cashBackSummary { get; set; }

            public class Delivery
            {
                public string badgeUrl { get; set; }
                public object company { get; set; }
                public object countDownMessage { get; set; }
                public object countDownMillisecond { get; set; }
                public object delayMessage { get; set; }
                public object deliveryExtraInfo { get; set; }
                public object deliveryNotice { get; set; }
                public object deliveryReminderMessage { get; set; }
                public object descriptionBadge { get; set; }
                public string descriptions { get; set; }
                public bool logistics { get; set; }
                public object loyaltyButtonText { get; set; }
                public bool rocketWowQuestionMark { get; set; }
                public object speedType { get; set; }
                public string type { get; set; }
            }
            public Delivery delivery { get; set; }
            public class Deliverylist
            {
                public string badgeUrl { get; set; }
                public object company { get; set; }
                public object countDownMessage { get; set; }
                public object countDownMillisecond { get; set; }
                public object delayMessage { get; set; }
                public object deliveryExtraInfo { get; set; }
                public object deliveryNotice { get; set; }
                public object deliveryReminderMessage { get; set; }
                public object descriptionBadge { get; set; }
                public string descriptions { get; set; }
                public bool logistics { get; set; }
                public object loyaltyButtonText { get; set; }
                public bool rocketWowQuestionMark { get; set; }
                public object speedType { get; set; }
                public string type { get; set; }
            }
            public Deliverylist[] deliveryList { get; set; }
            public class Price
            {
                public object cashPromotionMessage { get; set; }
                public object couponDiscountAmount { get; set; }
                public string couponPrice { get; set; }
                public object couponPriceTitle { get; set; }
                public object couponUnitPrice { get; set; }
                public object description { get; set; }
                public object discountRate { get; set; }
                public object gppuPricePolicy { get; set; }
                public object i18nCouponDiscountAmount { get; set; }
                public object i18nCouponPrice { get; set; }
                public object i18nOriginPrice { get; set; }
                public object i18nPriceAmount { get; set; }
                public class I18nsaleprice
                {
                    public string amount { get; set; }
                    public string currency { get; set; }
                    public int fractionDigits { get; set; }
                    public object rawAmount { get; set; }
                }
                public I18nsaleprice i18nSalePrice { get; set; }
                public bool instantDiscount { get; set; }
                public object instantPriceType { get; set; }
                public object loyaltyButtonText { get; set; }
                public object loyaltyRegistrationUrl { get; set; }
                public string originPrice { get; set; }
                public string originalPriceDesc { get; set; }
                public object priceAmount { get; set; }
                public string salePrice { get; set; }
                public object salePriceTitle { get; set; }
                public object saleUnitPrice { get; set; }
                public object title { get; set; }
                public object type { get; set; }
                public object unitDiscountRate { get; set; }
                public object unitPrice { get; set; }
                public bool wowCouponDiscount { get; set; }
            }
            public Price price { get; set; }
            public class Pricelist
            {
                public object cashPromotionMessage { get; set; }
                public object couponDiscountAmount { get; set; }
                public object couponPrice { get; set; }
                public object couponPriceTitle { get; set; }
                public object couponUnitPrice { get; set; }
                public object description { get; set; }
                public object discountRate { get; set; }
                public object gppuPricePolicy { get; set; }
                public object i18nCouponDiscountAmount { get; set; }
                public object i18nCouponPrice { get; set; }
                public object i18nOriginPrice { get; set; }
                public class I18npriceamount
                {
                    public string amount { get; set; }
                    public string currency { get; set; }
                    public int fractionDigits { get; set; }
                    public object rawAmount { get; set; }
                }
                public I18npriceamount i18nPriceAmount { get; set; }
                public object i18nSalePrice { get; set; }
                public object instantDiscount { get; set; }
                public object instantPriceType { get; set; }
                public object loyaltyButtonText { get; set; }
                public object loyaltyRegistrationUrl { get; set; }
                public object originPrice { get; set; }
                public object originalPriceDesc { get; set; }
                public string priceAmount { get; set; }
                public object salePrice { get; set; }
                public object salePriceTitle { get; set; }
                public object saleUnitPrice { get; set; }
                public string title { get; set; }
                public string type { get; set; }
                public object unitDiscountRate { get; set; }
                public string unitPrice { get; set; }
                public bool wowCouponDiscount { get; set; }
            }
            public Pricelist[] priceList { get; set; }
            public string priceUnit { get; set; }
            public int quantity { get; set; }
            public string shipmentDisplayType { get; set; }
            public class Shippingfee
            {
                public object freeShippingConditionMessage { get; set; }
                public string message { get; set; }
                public object returnFeeMessage { get; set; }
                public string shippingFeeType { get; set; }
            }
            public Shippingfee shippingFee { get; set; }
            public class Shippingfeelist
            {
                public object freeShippingConditionMessage { get; set; }
                public string message { get; set; }
                public object returnFeeMessage { get; set; }
                public string shippingFeeType { get; set; }
            }
            public Shippingfeelist[] shippingFeeList { get; set; }
            public object subscriptionDelivery { get; set; }
            public int subscriptionDiscountRate { get; set; }
            public object subscriptionPrice { get; set; }
            public object[] subscriptionPriceList { get; set; }
            public int wowOnlyInstantDiscountRate { get; set; }
        }
        public Quantitybase[] quantityBase { get; set; }
        public float ratingAveragePercentage { get; set; }
        public string ratingCount { get; set; }
        public bool restockNotification { get; set; }
        public object rodImageUrlInfoVo { get; set; }
        public int roleCode { get; set; }
        public class Sellinginfovo
        {
            public object countryOfOrigin { get; set; }
            public string[] sellingInfo { get; set; }
        }
        public Sellinginfovo sellingInfoVo { get; set; }
        public object shippingConsolidationLink { get; set; }
        public bool soldOut { get; set; }
        public class Stickbanner
        {
            public object adLoggingVo { get; set; }
            public string contents { get; set; }
            public string contentsType { get; set; }
        }
        public Stickbanner[] stickBanners { get; set; }
        public object subscribeInfo { get; set; }
        public object supplier { get; set; }
        public string title { get; set; }
        public object topSellingInfo { get; set; }
        public class Trackmeta
        {
            public int categoryId { get; set; }
            public long clickItemId { get; set; }
            public long clickProductId { get; set; }
            public long clickVendorItemId { get; set; }
            public object emailDealWithoutCookieMessage { get; set; }
            public bool emailEventDeal { get; set; }
            public string q { get; set; }
            public string sdpVisitKey { get; set; }
            public string searchId { get; set; }
            public string sourceType { get; set; }
            public string style { get; set; }
            public string traid { get; set; }
            public string trcid { get; set; }
        }
        public Trackmeta trackMeta { get; set; }
        public bool used { get; set; }
        public object vendor { get; set; }
        public long vendorItemId { get; set; }
        public bool wishList { get; set; }
    }
}
