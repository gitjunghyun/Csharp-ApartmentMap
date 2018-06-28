using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TeamProject1.procedure;

namespace TeamProject1.dao
{
    // ListDao 인터페이스를 추가해 필수 DB Access 메서드들을 추상메서드로 선언 예정
    class Dao
    {        
        // Default 생성자
        public Dao()
        {

        }

        // 커넥션 스트링 반환 메서드
        public string GetConnectionString()
        {
            return "server=210.123.254.61,1441; uid=cs2-01; pwd=1234; database=cProject;";
        }

        // ----------------------------------------------------------
        // 아파트 매매 데이터테이블 반환 메서드
        public DataSet GetAptData(string table)
        {
            DataTable dt;
            DataSet ds;
            string strConn = GetConnectionString(); // ConnectionURL
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                Console.WriteLine("Database = \t\t" + conn.Database);
                Console.WriteLine("DataSource = \t\t" + conn.DataSource);
                Console.WriteLine("DataServerVersion = \t" + conn.ServerVersion);
                Console.WriteLine("State = \t\t" + conn.State);

                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(procedure.Query.APTDATA, conn);
                adapter.Fill(ds, table);
                // 디비 테이블 가져오기
                dt = ds.Tables[table];
            }
            //printData(dt);
            return ds;
        }

        // 전/월세 데이터테이블 반환 메서드
        public DataSet GetAptDataRent(string table)
        {
            DataTable dt;
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                Console.WriteLine("Database = \t\t" + conn.Database);
                Console.WriteLine("DataSource = \t\t" + conn.DataSource);
                Console.WriteLine("DataServerVersion = \t" + conn.ServerVersion);
                Console.WriteLine("State = \t\t" + conn.State);

                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(procedure.Query.APTDATA_RENT, conn);
                adapter.Fill(ds, table);
                // 디비 테이블 가져오기
                dt = ds.Tables[table];
            }
            printData(dt);
            return ds;
        }
        // ------------------------------------------------------------

        // 아파트 매매 실거래 가공 컨트롤 페이지
        public DataSet GetAptDataSell()
        {
            DataTable dt;
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(procedure.Query.APTDATASELL, conn);
                adapter.Fill(ds, "aptdata");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata"];
            }
            printData(dt);
            return ds;
        }
        // 시군구 이름 - 콤보 박스
        public DataTable GetAptDataSell_City()
        {
            DataTable dt;
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(procedure.Query.APTDATASELL_CITYCOL, conn);
                adapter.Fill(ds, "aptdata");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata"];
            }
            //printData(dt);
            return dt;
        }
        // 동 이름 - 콤보 박스
        public DataTable GetAptDataSell_Dong(string selectCity)
        {
            DataTable dt;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                DataSet ds = new DataSet();
                // 쿼리문과 커넥트 연결
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_DONGCOL, conn);
                // 쿼리문 파라미터 전달
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                // 파라미터 속성에 추가
                paramCity.Value = selectCity;
                cmd.Parameters.Add(paramCity);
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata"];
            }
            printData(dt);
            return dt;
        }
        // 아파트 이름 가져오는 메서드 - 콤보 박스
        public DataTable GetAptDataSell_AptNm(string city, string dong)
        {
            DataTable dt;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                DataSet ds = new DataSet();
                // 쿼리문과 커넥트 연결
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_APTCOL, conn);
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramDong = new SqlParameter("@apt_dong", SqlDbType.VarChar, 50);
                paramDong.Value = dong;
                cmd.Parameters.Add(paramDong);
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata"];
            }
            printData(dt);
            return dt;
        }

        // -----------------------------------------------------------
        // 시군구 선택 시 데이터그리드 뷰 업데이트
        public DataSet GetAptDataSell_ComboBox_View(string city)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_C_VIEW, conn);
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);
                
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata");
            }
            return ds;
        }
        // 시군구, 동 이름으로 데이터 그리드 뷰
        public DataSet GetAptDataSell_ComboBox_View(string city, string dong)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_CD_VIEW, conn);
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramDong = new SqlParameter("@apt_dong", SqlDbType.VarChar, 50);
                paramDong.Value = dong;
                cmd.Parameters.Add(paramDong);

                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata");
            }
            return ds;
        }
        // 시군구 이름으로 데이터 그리드 뷰
        public DataSet GetAptDataSell_ComboBox_View(string city, string dong, string aptNm)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_CDN_VIEW, conn);
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramDong = new SqlParameter("@apt_dong", SqlDbType.VarChar, 50);
                paramDong.Value = dong;
                cmd.Parameters.Add(paramDong);

                SqlParameter paramAptNm = new SqlParameter("@apt_nm", SqlDbType.VarChar, 50);
                paramAptNm.Value = aptNm;
                cmd.Parameters.Add(paramAptNm);

                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata");
            }
            return ds;
        }

        // 아파트 매매가
        public DataSet GetAptDataSell_AptAmt(string amount)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                if(int.Parse(amount) > 90000)
                {
                    SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_APTAMT_LIMIT, conn);
                    // 파라미터 설정
                    SqlParameter pramAmt = new SqlParameter("@apt_cont_amt_start", SqlDbType.VarChar, 50);
                    pramAmt.Value = amount;
                    cmd.Parameters.Add(pramAmt);

                    // 디비 쿼리에 맞는 데이터를 가져와 저장
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "aptdata");
                } else
                {
                    SqlCommand cmd = new SqlCommand(procedure.Query.APTDATASELL_APTAMT, conn);
                    // 파라미터 설정
                    SqlParameter pramAmt = new SqlParameter("@apt_cont_amt_start", SqlDbType.VarChar, 50);
                    pramAmt.Value = amount;
                    cmd.Parameters.Add(pramAmt);

                    SqlParameter pramAmtE = new SqlParameter("@apt_cont_amt_end", SqlDbType.VarChar, 50);
                    pramAmtE.Value = (int.Parse(amount) + 10000);
                    cmd.Parameters.Add(pramAmtE);

                    // 디비 쿼리에 맞는 데이터를 가져와 저장
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "aptdata");
                }
            }
            return ds;
        }

        // ------------------------------------------------------------
        
        // 아파트 전/월세 데이터 정보
        public DataSet GetAptDataRentAll()
        {
            DataTable dt;
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(procedure.Query.APTDATARENT, conn);
                adapter.Fill(ds, "aptdata_rent");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata_rent"];
            }
            printData(dt);
            return ds;
        }
        // 아파트 전/월세 시군구 콤보박스
        public DataTable GetAptDataRent_City()
        {
            DataTable dt;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                DataSet ds = new DataSet();
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(procedure.Query.APTDATARENT_CITYCOL, conn);
                adapter.Fill(ds, "aptdata_rent");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata_rent"];
            }
            printData(dt);
            return dt;
        }
        // 아파트 전/월세 동 콤보박스
        public DataTable GetAptDataRent_Dong(string city)
        {
            DataTable dt;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_DONGCOL, conn);
                // 쿼리문 파라미터 전달
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                // 파라미터 속성에 추가
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds, "aptdata_rent");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata_rent"];
            }
            printData(dt);
            return dt;
        }
        // 아파트 전/월세 아파트 콤보 박스
        public DataTable GetAptDataRent_AptNm(string city, string dong)
        {
            DataTable dt;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                DataSet ds = new DataSet();
                // 쿼리문과 커넥트 연결
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_APTCOL, conn);
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramDong = new SqlParameter("@apt_dong", SqlDbType.VarChar, 50);
                paramDong.Value = dong;
                cmd.Parameters.Add(paramDong);
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata_rent");
                // 디비 테이블 가져오기
                dt = ds.Tables["aptdata_rent"];
            }
            printData(dt);
            return dt;
        }

        // 아파트 전/월세 시군구 그리드뷰
        public DataSet GetAptDataRent_ComboBox_View(string city)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_C_VIEW, conn);
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata_rent");
            }
            return ds;
        }
        // 아파트 전/월세 시군구, 동 그리드뷰
        public DataSet GetAptDataRent_ComboBox_View(string city, string dong)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_CD_VIEW, conn);
                
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramDong = new SqlParameter("@apt_dong", SqlDbType.VarChar, 50);
                paramDong.Value = dong;
                cmd.Parameters.Add(paramDong);
                
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata_rent");
            }
            return ds;
        }
        // 아파트 전/월세 시군구, 동, 아파트 그리드 뷰
        public DataSet GetAptDataRent_ComboBox_View(string city, string dong, string aptNm)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_CDN_VIEW, conn);
                // 파라미터 설정
                SqlParameter paramCity = new SqlParameter("@apt_city_nm", SqlDbType.VarChar, 50);
                paramCity.Value = city;
                cmd.Parameters.Add(paramCity);

                SqlParameter paramDong = new SqlParameter("@apt_dong", SqlDbType.VarChar, 50);
                paramDong.Value = dong;
                cmd.Parameters.Add(paramDong);

                SqlParameter paramAptNm = new SqlParameter("@apt_nm", SqlDbType.VarChar, 50);
                paramAptNm.Value = aptNm;
                cmd.Parameters.Add(paramAptNm);
                // 디비 쿼리에 맞는 데이터를 가져와 저장
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "aptdata_rent");
            }
            return ds;
        }

        // 아파트 매매가
        public DataSet GetAptDataRent_AptLease(string amount)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                if (int.Parse(amount) > 90)
                {
                    SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_APTLEASE_LIMIT, conn);
                    // 파라미터 설정
                    SqlParameter pramLease = new SqlParameter("@apt_Lease_start", SqlDbType.VarChar, 50);
                    pramLease.Value = amount;
                    cmd.Parameters.Add(pramLease);
                    // 디비 쿼리에 맞는 데이터를 가져와 저장
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "aptdata_rent");
                } else
                {
                    SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_APTLEASE, conn);
                    // 파라미터 설정
                    SqlParameter pramLease = new SqlParameter("@apt_Lease_start", SqlDbType.VarChar, 50);
                    pramLease.Value = amount;
                    cmd.Parameters.Add(pramLease);

                    SqlParameter pramLeaseE = new SqlParameter("@apt_Lease_end", SqlDbType.VarChar, 50);
                    pramLeaseE.Value = int.Parse(amount) + 10;
                    cmd.Parameters.Add(pramLeaseE);
                    // 디비 쿼리에 맞는 데이터를 가져와 저장
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "aptdata_rent");
                }
            }
            return ds;
        }
        // 아파트 전/월세 보증금
        public DataSet GetAptDataRent_AptDeposit(string amount)
        {
            DataSet ds;
            string strConn = GetConnectionString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //커넥션 시도
                conn.Open();
                // 디비 테이블의 스키마를 가져와 저장할 데이터 셋
                ds = new DataSet();
                if (int.Parse(amount) > 9000)
                {
                    SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_APTDEPOSIT_LIMIT, conn);
                    // 파라미터 설정
                    SqlParameter pramDeposit = new SqlParameter("@apt_Deposit_start", SqlDbType.VarChar, 50);
                    pramDeposit.Value = amount;
                    cmd.Parameters.Add(pramDeposit);
                    // 디비 쿼리에 맞는 데이터를 가져와 저장
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "aptdata_rent");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(procedure.Query.APTDATARENT_APTDEPOSIT, conn);
                    // 파라미터 설정
                    SqlParameter pramDeposit = new SqlParameter("@apt_Deposit_start", SqlDbType.VarChar, 50);
                    pramDeposit.Value = amount;
                    cmd.Parameters.Add(pramDeposit);

                    SqlParameter pramDepositE = new SqlParameter("@apt_Deposit_end", SqlDbType.VarChar, 50);
                    pramDepositE.Value = int.Parse(amount) + 1000;
                    cmd.Parameters.Add(pramDepositE);
                    // 디비 쿼리에 맞는 데이터를 가져와 저장
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "aptdata_rent");
                }
            }
            return ds;
        }

        // 데이터 출력 테스트 메서드
        public void printData(DataTable dt)
        {
            // 반복문 출력
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.Write(row[column] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
