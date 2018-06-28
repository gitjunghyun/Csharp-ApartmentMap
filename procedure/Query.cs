using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject1.procedure
{
    class Query
    {
        // 디비 원본데이터 아파트 매매
        public static string APTDATA =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_area_cd as 지번 "
                + ", apt_cont_year as 년 "
                + ", apt_cont_month as 월 "
                + ", apt_cont_day as 일 "
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", apt_area as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
                + ", apt_const_year as 건축년도 "
            + "from aptdata "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_cd "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_cont_amt "
                + ", apt_nm "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc"
                + ", apt_nm asc "
            ;

        // 아파트 매매 데이터 출력
        public static string APTDATASELL =
            "select " 
                // + "top(10) " // 테스트용 상위 10개
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
            + "from aptdata "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_cd "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_cont_amt "
                + ", apt_nm "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc"
            ;

        // 시군구 중복 제거 후에 한가지만 출력 - 콤보 박스
        public static string APTDATASELL_CITYCOL =
            "select "
                + "apt_city_nm "
            + "from "
                + "aptdata "
            + "group by "
                + "apt_city_nm "
            + "order by "
                + "apt_city_nm asc "
            ;
        // 시군구 설정 시 전체 데이터 - 데이터 그리드 뷰
        public static string APTDATASELL_C_VIEW =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + " apt_city_nm as 시군구" // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
            + "from aptdata "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_cd "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_cont_amt "
                + ", apt_nm "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc"
                + ", apt_cont_amt asc"
            ;
        // 시군구, 동 설정 시 전체 데이터 - 데이터 그리드 뷰
        public static string APTDATASELL_CD_VIEW =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동"  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
            + "from aptdata "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "and apt_dong = @apt_dong "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_cd "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_cont_amt "
                + ", apt_nm "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc"
                + ", apt_cont_amt asc"
            ;
        // 시군구, 동, 아파트  설정 시 전체 데이터 - 데이터 그리드 뷰
        public static string APTDATASELL_CDN_VIEW =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
            + "from aptdata "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "and apt_dong = @apt_dong "
            + "and apt_nm = @apt_nm "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_cd "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_cont_amt "
                + ", apt_nm "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc "
                + ", apt_cont_amt asc "
            ;

        // 시군구가 결정 -> 동 이름 출력 - 콤보 박스
        public static string APTDATASELL_DONGCOL =
            "select "
                + "apt_dong "
            + "from "
                + "aptdata "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "group by "
                + "apt_city_nm "
                + ", apt_dong "
            ;

        // 시군구, 동이 결정 -> 아파트 이름 출력 - 콤보박스
        public static string APTDATASELL_APTCOL =
            "select "
                + "apt_nm "
            + "from "
                + "aptdata "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "and apt_dong = @apt_dong "
            + "group by "
                + "apt_city_nm "
                + ", apt_dong "
                + ", apt_nm "
            ;

        
        // 거래 금액 계산 쿼리 - 쓸모 없을 듯
        public static string APTDATASELL_APTAMT =
            "select "
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
            + "from aptdata "
            + "where 1 = 1 " 
            // + "and convert(numeric,replace(apt_cont_amt, ',', '')) >= @apt_cont_amt_start "
            // + "and convert(numeric,replace(apt_cont_amt, ',', '')) < @apt_cont_amt_end "
            + "and convert(numeric,replace(apt_cont_amt, ',', '')) between @apt_cont_amt_start "
            + "and @apt_cont_amt_end "
            //+ "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
            //    + "apt_city_nm "
            //    + ", apt_dong "  // 동
            //    + ", apt_nm "    // 아파트 이름
            //    + ", apt_fl "    // 층
            //    + ", apt_area " // 면적 제곱미터 -> 평 환산
            //    + ", apt_cont_amt "
            + "order by " 
                + "convert(numeric,replace(apt_cont_amt, ',', '')) "
                + "asc "
            ;

        // 거래 금액 계산 쿼리 - 쓸모 없을 듯
        public static string APTDATASELL_APTAMT_LIMIT =
            "select "
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_cont_amt as 거래금액 " // 거래금액
            + "from aptdata "
            + "where 1 = 1 "
            + "and convert(numeric,replace(apt_cont_amt, ',', '')) >= @apt_cont_amt_start "
            + "order by "
                + "convert(numeric,replace(apt_cont_amt, ',', '')) "
                + "asc "
            ;
        // ---------------------------------------------------------------
        // 디비 원본 데이터 - 전/월세
        public static string APTDATA_RENT =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + "apt_city_nm as 시군구 " // 시군구
                + ", apt_area_code as 지번 "
                + ", apt_cont_year as 년 "
                + ", apt_cont_month as 월 "
                + ", apt_cont_day as 일 "
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", apt_area as 거래금액 " // 면적 제곱미터 -> 평 환산
                + ", apt_deposit as 보증금 " // 거래금액
                + ", apt_lease as 월세 "
                + ", apt_const_year as 건축년도 "
            + "from aptdata_rent "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_code "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_nm "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_deposit "
                + ", apt_lease "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc "
                + ", apt_dong asc "
                + ", apt_nm asc "
            ;
        // 전/월세 값
        public static string APTDATARENT =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + "apt_city_nm as 시군구 " // 시군구
                // + ", apt_area_code as 지번 "
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_deposit as 보증금 " // 거래금액
                + ", apt_lease as 월세 "
            + "from aptdata_rent "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_code "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_nm "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_deposit "
                + ", apt_lease "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc "
                + ", apt_dong asc "
                + ", apt_nm asc "
            ;

        // 시군구 설정 시 전체 데이터 - 데이터 그리드 뷰
        public static string APTDATARENT_C_VIEW =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + "apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_deposit as 보증금 " // 거래금액
                + ", apt_lease as 월세 "
            + "from aptdata_rent "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_code "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_nm "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_deposit "
                + ", apt_lease "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc "
                + ", apt_dong asc "
            ;

        // 시군구, 동 설정 시 전체 데이터 - 데이터 그리드 뷰
        public static string APTDATARENT_CD_VIEW =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + "apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_deposit as 보증금 " // 거래금액
                + ", apt_lease as 월세 "
            + "from aptdata_rent "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "and apt_dong = @apt_dong "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_code "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_nm "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_deposit "
                + ", apt_lease "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc "
                + ", apt_dong asc "
            ;

        // 시군구, 동 설정 시 전체 데이터 - 데이터 그리드 뷰
        public static string APTDATARENT_CDN_VIEW =
            "select "
                // + "top(10) " // 테스트용 상위 10개
                + "apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_deposit as 보증금 " // 거래금액
                + ", apt_lease as 월세 "
            + "from aptdata_rent "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "and apt_dong = @apt_dong "
            + "and apt_nm = @apt_nm "
            + "group by " // 밑에 선언된 컬럼을 기준으로 데이터를 묶는다.
                + "apt_city_nm "
                + ", apt_area_code "
                + ", apt_cont_year "
                + ", apt_cont_month "
                + ", apt_cont_day "
                + ", apt_dong "
                + ", apt_nm "
                + ", apt_fl "
                + ", apt_area "
                + ", apt_deposit "
                + ", apt_lease "
                + ", apt_const_year "
            + "order by "
                + "apt_city_nm asc "
                + ", apt_dong asc "
                + ", apt_nm asc "
            ;
        // 시군구 중복 제거 후에 한가지만 출력
        public static string APTDATARENT_CITYCOL =
            "select "
                + "apt_city_nm "
            + "from "
                + "aptdata_rent "
            + "group by "
                + "apt_city_nm "
            + "order by "
                + "apt_city_nm asc "
            ;

        // 시군구가 결정 -> 동 이름 출력
        public static string APTDATARENT_DONGCOL =
            "select "
                + "apt_dong "
            + "from "
                + "aptdata_rent "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "group by "
                + "apt_city_nm "
                + ", apt_dong "
            + "order by "
                + "apt_city_nm asc "
            ;

        // 시군구, 동이 결정 -> 아파트 이름 출력
        public static string APTDATARENT_APTCOL =
            "select "
                + "apt_nm "
            + "from "
                + "aptdata "
            + "where 1 = 1 "
            + "and apt_city_nm = @apt_city_nm "
            + "and apt_dong = @apt_dong "
            + "group by "
                + "apt_city_nm "
                + ", apt_dong "
                + ", apt_nm "
            + "order by "
                + "apt_city_nm asc"
            ;

      public static string APTDATARENT_APTLEASE =
           "select "
               + " apt_city_nm as 시군구 " // 시군구
               + ", apt_dong as 동 "  // 동
               + ", apt_nm as 아파트 "    // 아파트 이름
               + ", apt_fl as 층 "    // 층
               + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
               + ", apt_lease as 월세 " // 거래금액
               + ", apt_deposit as 보증금 "
           + "from aptdata_rent "
           + "where 1 = 1 "
           + "and convert(numeric,replace(apt_lease, ',', '')) between @apt_Lease_start "
           + "and @apt_Lease_end "
           + "order by "
               + "convert(numeric,replace(apt_lease, ',', '')) "
               + "asc "
           ;
        public static string APTDATARENT_APTLEASE_LIMIT =
            "select "
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_lease as 거래금액 " // 거래금액
                + ", apt_deposit as 보증금 "
            + "from aptdata_rent "
            + "where 1 = 1 "
            + "and convert(numeric,replace(apt_lease, ',', '')) >= @apt_Lease_start "
            + "order by "
                + "convert(numeric,replace(apt_lease, ',', '')) "
                + "asc "
            ;
        // 보증금
        public static string APTDATARENT_APTDEPOSIT =
            "select "
               + " apt_city_nm as 시군구 " // 시군구
               + ", apt_dong as 동 "  // 동
               + ", apt_nm as 아파트 "    // 아파트 이름
               + ", apt_fl as 층 "    // 층
               + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
               + ", apt_lease as 월세 " // 거래금액
               + ", apt_deposit as 보증금 "
           + "from aptdata_rent "
           + "where 1 = 1 "
           + "and convert(numeric,replace(apt_deposit, ',', '')) between @apt_deposit_start "
           + "and @apt_deposit_end "
           + "order by "
               + "convert(numeric,replace(apt_deposit, ',', '')) "
               + "asc "
           ;
        public static string APTDATARENT_APTDEPOSIT_LIMIT = 
            "select "
                + " apt_city_nm as 시군구 " // 시군구
                + ", apt_dong as 동 "  // 동
                + ", apt_nm as 아파트 "    // 아파트 이름
                + ", apt_fl as 층 "    // 층
                + ", floor(round(convert(numeric, apt_area) * 0.3025, 0)) as 면적 " // 면적 제곱미터 -> 평 환산
                + ", apt_lease as 거래금액 " // 거래금액
                + ", apt_deposit as 보증금 "
            + "from aptdata_rent "
            + "where 1 = 1 "
            + "and convert(numeric,replace(apt_deposit, ',', '')) >= @apt_deposit_start "
            + "order by "
                + "convert(numeric,replace(apt_deposit, ',', '')) "
                + "asc "
            ;
    }
}
