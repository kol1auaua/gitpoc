using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace Frotcom.Data.Models.Vehicles
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TollSystemNationalitys
    {
        [Description("country-BGR")]
        Country_BG = 1,
        [Description("country-ALB")]
        Country_AL = 2,
        [Description("country-AND")]
        Country_AD = 3,
        [Description("country-AUT")]
        Country_AT = 4,
        [Description("country-BLR")]
        Country_BY = 5,
        [Description("country-BEL")]
        Country_BE = 6,
        [Description("country-BIH")]
        Country_BA = 7,
        [Description("country-HRV")]
        Country_HR = 8,
        [Description("country-CYP")]
        Country_CY = 9,
        [Description("country-CZE")]
        Country_CZ = 10,
        [Description("country-DNK")]
        Country_DK = 11,
        [Description("country-EST")]
        Country_EE = 12,
        [Description("country-FRO")]
        Country_FO = 13,
        [Description("country-FIN")]
        Country_FI = 14,
        [Description("country-FRA")]
        Country_FR = 15,
        [Description("country-DEU")]
        Country_DE = 16,
        [Description("country-GIB")]
        Country_GI = 17,
        [Description("country-GRC")]
        Country_GR = 18,
        [Description("country-HUN")]
        Country_HU = 19,
        [Description("country-ISL")]
        Country_IS = 20,
        [Description("country-IRL")]
        Country_IE = 21,
        [Description("country-IMN")]
        Country_IM = 22,
        [Description("country-ITA")]
        Country_IT = 23,
        [Description("country-XKX")]
        Country_XK = 24,
        [Description("country-LVA")]
        Country_LV = 25,
        [Description("country-LIE")]
        Country_LI = 26,
        [Description("country-LTU")]
        Country_LT = 27,
        [Description("country-LUX")]
        Country_LU = 28,
        [Description("country-MKD")]
        Country_MK = 29,
        [Description("country-MLT")]
        Country_MT = 30,
        [Description("country-MDA")]
        Country_MD = 31,
        [Description("country-MCO")]
        Country_MC = 32,
        [Description("country-MNE")]
        Country_ME = 33,
        [Description("country-NLD")]
        Country_NL = 34,
        [Description("country-NOR")]
        Country_NO = 35,
        [Description("country-POL")]
        Country_PL = 36,
        [Description("country-PRT")]
        Country_PT = 37,
        [Description("country-ROU")]
        Country_RO = 38,
        [Description("country-RUS")]
        Country_RU = 39,
        [Description("country-SMR")]
        Country_SM = 40,
        [Description("country-SRB")]
        Country_RS = 41,
        [Description("country-SVK")]
        Country_SK = 42,
        [Description("country-SVN")]
        Country_SI = 43,
        [Description("country-ESP")]
        Country_ES = 44,
        [Description("country-SWE")]
        Country_SE = 45,
        [Description("country-CHE")]
        Country_CH = 46,
        [Description("country-UKR")]
        Country_UA = 47,
        [Description("country-GBR")]
        Country_GB = 48,
        [Description("country-VAT")]
        Country_VA = 49,
        [Description("country-RSB")]
        Country_YU = 50,
        [Description("country-ABW")]
        Country_AW = 51,
        [Description("country-AFG")]
        Country_AG = 52,
        [Description("country-AIA")]
        Country_AI = 53,
        [Description("country-ALA")]
        Country_AX = 54,
        [Description("country-ARG")]
        Country_AR = 55,
        [Description("country-ASM")]
        Country_AS = 56,
        [Description("country-ATA")]
        Country_AQ = 57,
        [Description("country-AUS")]
        Country_AU = 58,
        [Description("country-AZE")]
        Country_AZ = 59,
        [Description("country-BDI")]
        Country_BI = 60,
        [Description("country-BEN")]
        Country_BJ = 61,
        [Description("country-BES")]
        Country_BQ = 62,
        [Description("country-BFA")]
        Country_BF = 63,
        [Description("country-BGD")]
        Country_BD = 64,
        [Description("country-BHR")]
        Country_BH = 65,
        [Description("country-BHS")]
        Country_BS = 66,
        [Description("country-BLM")]
        Country_BL = 67,
        [Description("country-BLZ")]
        Country_BZ = 68,
        [Description("country-BMU")]
        Country_BM = 69,
        [Description("country-BOL")]
        Country_BO = 70,
        [Description("country-BRB")]
        Country_BB = 71,
        [Description("country-BRN")]
        Country_BN = 72,
        [Description("country-BTN")]
        Country_BT = 73,
        [Description("country-BVT")]
        Country_BV = 74,
        [Description("country-BWA")]
        Country_BW = 75,
        [Description("country-CAF")]
        Country_CF = 76,
        [Description("country-CHL")]
        Country_CL = 77,
        [Description("country-CHN")]
        Country_CN = 78,
        [Description("country-CIV")]
        Country_CI = 79,
        [Description("country-CMR")]
        Country_CM = 80,
        [Description("country-COG")]
        Country_CG = 81,
        [Description("country-COK")]
        Country_CK = 82,
        [Description("country-COL")]
        Country_CO = 83,
        [Description("country-COM")]
        Country_KM = 84,
        [Description("country-CPV")]
        Country_CV = 85,
        [Description("country-CUW")]
        Country_CW = 86,
        [Description("country-CYM")]
        Country_KY = 87,
        [Description("country-ZMB")]
        Country_ZM = 88,
        [Description("country-DJI")]
        Country_DI = 89,
        [Description("country-DMA")]
        Country_DM = 90,
        [Description("country-DOM")]
        Country_DO = 91,
        [Description("country-DZA")]
        Country_DZ = 92,
        [Description("country-ECU")]
        Country_EC = 93,
        [Description("country-EGY")]
        Country_EG = 94,
        [Description("country-ERI")]
        Country_ER = 95,
        [Description("country-ESH")]
        Country_EH = 96,
        [Description("country-ETH")]
        Country_ET = 97,
        [Description("country-FJI")]
        Country_FJ = 98,
        [Description("country-GEO")]
        Country_GE = 99,
        [Description("country-GHA")]
        Country_GH = 100,
        [Description("country-GIN")]
        Country_GN = 101,
        [Description("country-GLP")]
        Country_GP = 102,
        [Description("country-GMB")]
        Country_GM = 103,
        [Description("country-GNB")]
        Country_GW = 104,
        [Description("country-GRD")]
        Country_GD = 105,
        [Description("country-GRL")]
        Country_GL = 106,
        [Description("country-GTM")]
        Country_GT = 107,
        [Description("country-GUF")]
        Country_GF = 108,
        [Description("country-HKG")]
        Country_HK = 109,
        [Description("country-HND")]
        Country_HN = 110,
        [Description("country-HTI")]
        Country_HT = 111,
        [Description("country-IDN")]
        Country_ID = 112,
        [Description("country-IND")]
        Country_IN = 113,
        [Description("country-IRN")]
        Country_IR = 114,
        [Description("country-IRQ")]
        Country_IQ = 115,
        [Description("country-ISR")]
        Country_IL = 116,
        [Description("country-JOR")]
        Country_JO = 117,
        [Description("country-JPN")]
        Country_JP = 118,
        [Description("country-KAZ")]
        Country_KZ = 119,
        [Description("country-KEN")]
        Country_KE = 120,
        [Description("country-KGZ")]
        Country_KG = 121,
        [Description("country-KHM")]
        Country_KH = 122,
        [Description("country-KIR")]
        Country_KI = 123,
        [Description("country-KNA")]
        Country_KN = 124,
        [Description("country-KOR")]
        Country_KR = 125,
        [Description("country-KWT")]
        Country_KW = 126,
        [Description("country-LBN")]
        Country_LB = 127,
        [Description("country-LBR")]
        Country_LR = 128,
        [Description("country-LBY")]
        Country_LY = 129,
        [Description("country-LCA")]
        Country_LC = 130,
        [Description("country-LKA")]
        Country_LK = 131,
        [Description("country-LSO")]
        Country_LS = 132,
        [Description("country-MAC")]
        Country_MO = 133,
        [Description("country-MAR")]
        Country_MA = 134,
        [Description("country-MDG")]
        Country_MG = 135,
        [Description("country-MDV")]
        Country_MV = 136,
        [Description("country-MEX")]
        Country_MX = 137,
        [Description("country-MHL")]
        Country_MH = 138,
        [Description("country-MLI")]
        Country_ML = 139,
        [Description("country-MMR")]
        Country_MM = 140,
        [Description("country-MNG")]
        Country_MNG = 141,
        [Description("country-MNP")]
        Country_MP = 142,
        [Description("country-MOZ")]
        Country_MZ = 143,
        [Description("country-MRT")]
        Country_MR = 144,
        [Description("country-MSR")]
        Country_MS = 145,
        [Description("country-MTQ")]
        Country_MQ = 146,
        [Description("country-MUS")]
        Country_MU = 147,
        [Description("country-MWI")]
        Country_MW = 148,
        [Description("country-MYS")]
        Country_MY = 149,
        [Description("country-MYT")]
        Country_YT = 150,
        [Description("country-NAM")]
        Country_NA = 151,
        [Description("country-NCL")]
        Country_NC = 152,
        [Description("country-NER")]
        Country_NE = 153,
        [Description("country-NGA")]
        Country_NG = 154,
        [Description("country-NIC")]
        Country_NI = 155,
        [Description("country-NIU")]
        Country_NU = 156,
        [Description("country-NPL")]
        Country_NP = 157,
        [Description("country-NRU")]
        Country_NR = 158,
        [Description("country-NZL")]
        Country_NZ = 159,
        [Description("country-OMN")]
        Country_OM = 160,
        [Description("country-PAK")]
        Country_PK = 161,
        [Description("country-PAN")]
        Country_PA = 162,
        [Description("country-PHL")]
        Country_PH = 163,
        [Description("country-PLW")]
        Country_PW = 164,
        [Description("country-PNG")]
        Country_PG = 165,
        [Description("country-PRI")]
        Country_PR = 166,
        [Description("country-PRK")]
        Country_RK = 167,
        [Description("country-PSE")]
        Country_PS = 168,
        [Description("country-PYF")]
        Country_PF = 169,
        [Description("country-QAT")]
        Country_QA = 170,
        [Description("country-RWA")]
        Country_RW = 171,
        [Description("country-SAU")]
        Country_SA = 172,
        [Description("country-SDN")]
        Country_SD = 173,
        [Description("country-SEN")]
        Country_SN = 174,
        [Description("country-SLB")]
        Country_SB = 175,
        [Description("country-SLE")]
        Country_SL = 176,
        [Description("country-SLV")]
        Country_SV = 177,
        [Description("country-SOM")]
        Country_SO = 178,
        [Description("country-SSD")]
        Country_SS = 179,
        [Description("country-STP")]
        Country_ST = 180,
        [Description("country-SYC")]
        Country_SC = 181,
        [Description("country-SYR")]
        Country_SY = 182,
        [Description("country-THA")]
        Country_TH = 183,
        [Description("country-TJK")]
        Country_TJ = 184,
        [Description("country-TKL")]
        Country_TK = 185,
        [Description("country-TKM")]
        Country_TM = 186,
        [Description("country-TLS")]
        Country_TL = 187,
        [Description("country-TTO")]
        Country_TT = 188,
        [Description("country-TUN")]
        Country_TN = 189,
        [Description("country-TUR")]
        Country_TR = 190,
        [Description("country-TWN")]
        Country_TW = 191,
        [Description("country-TZA")]
        Country_TZ = 192,
        [Description("country-UGA")]
        Country_UG = 193,
        [Description("country-URY")]
        Country_UY = 194,
        [Description("country-UZB")]
        Country_UZ = 195,
        [Description("country-VCT")]
        Country_VC = 196,
        [Description("country-VEN")]
        Country_VE = 197,
        [Description("country-VNM")]
        Country_VN = 198,
        [Description("country-VUT")]
        Country_VU = 199,
        [Description("country-WSM")]
        Country_WS = 200,
        [Description("country-ZAF")]
        Country_ZA = 201
    }
}
