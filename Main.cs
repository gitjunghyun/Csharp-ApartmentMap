using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamProject1.dao;
using System.Security.Permissions;
using System.Runtime.InteropServices;


namespace TeamProject1
{
    public partial class MainForm : Form
    {
        private Map map = new Map();
        private Dao dao = new Dao();
        private string selectCity;
        private string selectDong;
        private string selectAptNm;

        public MainForm()
        {
            InitializeComponent();
        }

        // 메인 폼 로드
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // 매매 데이터 
            DataSet ds = dao.GetAptData("aptdata");
            dataGridView_sell_data.DataSource = ds.Tables[0];
            // 매매 가공 데이터
            DataSet ds_view = dao.GetAptDataSell();
            dataGridView_sell_view.DataSource = ds_view.Tables[0];
            // 전/월세 데이터
            DataSet ds_rent = dao.GetAptDataRent("aptdata_rent");
            dataGridView_rent_data.DataSource = ds_rent.Tables[0];
            // 전/월세 가공 데이터
            DataSet ds_rent_view = dao.GetAptDataRentAll();
            dataGridView_rent_view.DataSource = ds_rent_view.Tables[0];

            aptLeaseInit();
            aptDepositInit();
            aptAmtInit();
            // '시군구' 콤보박스 초기화 메서드 호출    
            initComboBoxItems_City();
        }
        // 돈관련 콤보박스 리셋
        private void aptLeaseInit()
        {
            for (int i = 0; i <= 100; i = i + 10)
                if (i < 100)
                    comboBox_rent_aptLease.Items.Add(i);
                else
                    comboBox_rent_aptLease.Items.Add(i);
        }
        private void aptDepositInit()
        {
            for (int i = 0; i <= 10000; i = i + 1000)
                if (i < 10000)
                {
                    comboBox_rent_aptDeposit.Items.Add(i);
                }
                else
                {
                    comboBox_rent_aptDeposit.Items.Add(i);
                }
        }
        private void aptAmtInit()
        {
            // 컬렉션 값을 넣으려고 했더니 Dictionary 밖에 안들어감
            // Display, ValueMember 속성으로 이루어 져있다.
            // 값 콤보 박스 초기화 이 방법 뿐인가?
            for (int i = 0; i <= 10000; i = i + 1000)
                if (i < 10000)
                {
                    comboBox_sell_aptAmt.Items.Add(i * 10);
                }
                else
                {
                    comboBox_sell_aptAmt.Items.Add(99999);
                }
        }
        // '시군구' 콤보박스 초기화
        private void initComboBoxItems_City()
        {
            // Sell ComboBox City 초기 세팅
            DataTable dt_sell_city = dao.GetAptDataSell_City();
            foreach (DataRow item in dt_sell_city.Rows)
            {
                foreach (DataColumn it in dt_sell_city.Columns)
                {
                    comboBox_sell_aptCity.Items.Add(item[it]);
                }
            }
            
            // Rent ComboBox City 초기 세팅
            DataTable dt_rent_city = dao.GetAptDataRent_City();
            foreach (DataRow item in dt_rent_city.Rows)
            {
                foreach (DataColumn it in dt_rent_city.Columns)
                {
                    comboBox_rent_aptCity.Items.Add(item[it]);
                }
            }
        }
        private void clearComboBoxItems()
        {
            comboBox_sell_aptCity.Items.Clear(); // 매매 '시군구'
            comboBox_sell_aptDong.Items.Clear(); // 매매 '동'
            comboBox_sell_aptNm.Items.Clear();  // 매매 '아파트'
            comboBox_sell_aptAmt.Items.Clear(); // 매매 '매매가'
            comboBox_rent_aptCity.Items.Clear();    // 전/월세 '시군구'
            comboBox_rent_aptDong.Items.Clear();    // 전/월세 '동'
            comboBox_rent_aptNm.Items.Clear();      // 전/월세 '아파트'
            comboBox_rent_aptDeposit.Items.Clear(); // 전/월세 '보증금'
            comboBox_rent_aptLease.Items.Clear();   // 전/월세 '월세'

        }
        
        // 아파트 매매 탭 -> 콤보박스 설정

        // '시군구' 콤보박스 선택 시 '동' 콤보박스, 데이터그리드뷰 목록 갱신 메서드
        private void comboBox_sell_aptCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 시군구 설정
            selectCity = comboBox_sell_aptCity.SelectedItem.ToString();
            // 콤보박스, 데이터 그리드 뷰 갱신
            comboBox_sell_aptDong.Items.Clear();
            comboBox_sell_aptNm.Items.Clear();
            comboBox_sell_aptAmt.Items.Clear();
            dataGridView_sell_view.Update();
            aptAmtInit();
            // ComboBox Dong
            DataTable dt_sell_dong = dao.GetAptDataSell_Dong(selectCity);
            foreach (DataRow item in dt_sell_dong.Rows)
            {
                foreach (DataColumn it in dt_sell_dong.Columns)
                {
                    comboBox_sell_aptDong.Items.Add(item[it]);
                }
            }

            DataSet ds = dao.GetAptDataSell_ComboBox_View(selectCity);
            dataGridView_sell_view.DataSource = ds.Tables["aptdata"];
        }
        // '시군구', '동' 콤보박스 선택 시 '아파트' 콤보박스, 데이터그리드뷰 목록 갱신
        private void comboBox_sell_aptDong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 시군구, 동 설정
            selectCity = comboBox_sell_aptCity.SelectedItem.ToString();
            selectDong = comboBox_sell_aptDong.SelectedItem.ToString();
            // 콤보박스, 데이터그리드뷰 갱신
            comboBox_sell_aptNm.Items.Clear();
            dataGridView_sell_view.Update();
            // 콤보 박스 업데이트
            DataTable dt_sell_aptNm = dao.GetAptDataSell_AptNm(selectCity, selectDong);
            foreach (DataRow item in dt_sell_aptNm.Rows)
            {
                foreach (DataColumn it in dt_sell_aptNm.Columns)
                {
                    comboBox_sell_aptNm.Items.Add(item[it]);
                }
            }
            // 데이터 그리드 뷰 업데이트
            DataSet ds = dao.GetAptDataSell_ComboBox_View(selectCity, selectDong);
            dataGridView_sell_view.DataSource = ds.Tables["aptdata"];
        }
        // '시군구' 콤보박스, '동', '아파트' 콤보박스 선택 시 데이터 그리드 뷰 목록 갱신
        private void comboBox_sell_aptNm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 시군구, 동, 아파트명 설정
            selectCity = comboBox_sell_aptCity.SelectedItem.ToString();
            selectDong = comboBox_sell_aptDong.SelectedItem.ToString();
            selectAptNm = comboBox_sell_aptNm.SelectedItem.ToString();
            // 데이터 그리드 뷰 갱신
            dataGridView_sell_view.Update();

            // 데이터 그리드 뷰 데이터 
            DataSet ds = dao.GetAptDataSell_ComboBox_View(selectCity, selectDong, selectAptNm);
            dataGridView_sell_view.DataSource = ds.Tables["aptdata"];
        }

        // '매매가격' 콤보 박스 선택 시 데이터 그리드 뷰 목록 갱신 메서드
        private void comboBox_sell_aptAmt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strAmt = comboBox_sell_aptAmt.SelectedItem.ToString();
            comboBox_sell_aptCity.Items.Clear(); // 매매 '시군구'
            comboBox_sell_aptDong.Items.Clear(); // 매매 '동'
            comboBox_sell_aptNm.Items.Clear();  // 매매 '아파트'
            initComboBoxItems_City();
            dataGridView_sell_view.Update();
            // 매매가격 선택 시 가격 범위에 따른 DataGridView 값 설정
            // MessageBox.Show(strAmt);
            DataSet ds = dao.GetAptDataSell_AptAmt(strAmt);
            dataGridView_sell_view.DataSource = ds.Tables["aptdata"];
        }
        
        // ----------------------------------------------------------------------
        // 아파트 전/월세 탭 -> 콤보박스 설정

        // '시군구' 콤보박스 선택 시 '동' 콤보박스, 데이터그리드뷰 목록 갱신 메서드
        private void comboBox_rent_aptCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 전/월세 시군구 탭 값
            selectCity = comboBox_rent_aptCity.SelectedItem.ToString();
            // 콤보박스, 데이터 그리드 뷰 갱신
            comboBox_rent_aptDong.Items.Clear();
            comboBox_rent_aptNm.Items.Clear();
            comboBox_rent_aptDeposit.Items.Clear();
            comboBox_rent_aptLease.Items.Clear();
            dataGridView_rent_view.Update();

            aptLeaseInit();
            aptDepositInit();
            // ComboBox Dong
            DataTable dt_rent_dong = dao.GetAptDataRent_Dong(selectCity);
            foreach (DataRow item in dt_rent_dong.Rows)
            {
                foreach (DataColumn it in dt_rent_dong.Columns)
                {
                    comboBox_rent_aptDong.Items.Add(item[it]);
                }
            }

            DataSet ds = dao.GetAptDataRent_ComboBox_View(selectCity);
            dataGridView_rent_view.DataSource = ds.Tables["aptdata_rent"];
        }
        // '시군구', '동' 콤보박스 선택 시 '아파트' 콤보박스, 데이터그리드뷰 목록 갱신
        private void comboBox_rent_aptDong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 전/월세 시군구 탭 값
            selectCity = comboBox_rent_aptCity.SelectedItem.ToString();
            selectDong = comboBox_rent_aptDong.SelectedItem.ToString();
            // 콤보박스, 데이터 그리드 뷰 갱신
            comboBox_rent_aptNm.Items.Clear();
            dataGridView_rent_view.Update();

            // ComboBox Dong
            DataTable dt_rent_aptNm = dao.GetAptDataRent_AptNm(selectCity, selectDong);
            foreach (DataRow item in dt_rent_aptNm.Rows)
            {
                foreach (DataColumn it in dt_rent_aptNm.Columns)
                {
                    comboBox_rent_aptNm.Items.Add(item[it]);
                }
            }

            DataSet ds = dao.GetAptDataRent_ComboBox_View(selectCity, selectDong);
            dataGridView_rent_view.DataSource = ds.Tables["aptdata_rent"];
        }
        // '시군구', '동', '아파트' 콤보박스 선택 시 데이터 그리드 뷰 목록 갱신
        private void comboBox_rent_aptNm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 시군구, 동, 아파트명 설정
            selectCity = comboBox_rent_aptCity.SelectedItem.ToString();
            selectDong = comboBox_rent_aptDong.SelectedItem.ToString();
            selectAptNm = comboBox_rent_aptNm.SelectedItem.ToString();
            // 데이터 그리드 뷰 갱신
            dataGridView_rent_view.Update();

            // 데이터 그리드 뷰 데이터 
            DataSet ds = dao.GetAptDataRent_ComboBox_View(selectCity, selectDong, selectAptNm);
            dataGridView_rent_view.DataSource = ds.Tables["aptdata_rent"];
        }
        // ---------------------------------------------------------------------
        
        // '월세' 콤보박스 선택 시 데이터그리드뷰 목록 갱신 메서드
        private void comboBox_rent_aptLease_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strAmt = comboBox_rent_aptLease.SelectedItem.ToString();
            // '월세' 콤보박스를 제외한 모든 콤보박스 아이템 리셋
            comboBox_rent_aptCity.Items.Clear();    // 전/월세 '시군구'
            comboBox_rent_aptDong.Items.Clear();    // 전/월세 '동'
            comboBox_rent_aptNm.Items.Clear();      // 전/월세 '아파트'
            comboBox_rent_aptDeposit.Items.Clear(); // 전/월세 '보증금'
            // '시군구' 콤보박스 아이템 재설정
            initComboBoxItems_City();
            aptDepositInit();
            // 데이터 그리드 뷰에 데이터 출력
            DataSet ds = dao.GetAptDataRent_AptLease(strAmt);
            dataGridView_rent_view.DataSource = ds.Tables["aptdata_rent"];
        }
        // '보증금' 콤보박스 선택 시 데이터그리드뷰 목록 갱신 메서드
        private void comboBox_rent_aptDeposit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strAmt = comboBox_rent_aptDeposit.SelectedItem.ToString();
            // '월세' 콤보박스를 제외한 모든 콤보박스 아이템 리셋
            comboBox_rent_aptCity.Items.Clear();    // 전/월세 '시군구'
            comboBox_rent_aptDong.Items.Clear();    // 전/월세 '동'
            comboBox_rent_aptNm.Items.Clear();      // 전/월세 '아파트'
            comboBox_rent_aptLease.Items.Clear();   // 전/월세 '월세'
            // '시군구' 콤보박스 아이템 재설정
            initComboBoxItems_City();
            aptLeaseInit();
            DataSet ds = dao.GetAptDataRent_AptDeposit(strAmt);
            dataGridView_rent_view.DataSource = ds.Tables["aptdata_rent"];
        }    
        // 더블클릭 이벤트 발생 시
        private void dataGridView_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView 셀 클릭 시 클릭한 위치 정보에 대해 갖고 있는 sender와 셀의 정보를 갖고 있는 e를 이용하여 둘 이상의 객체를 하나의 메서드로 컨트롤
            DataGridViewRow row = CellContentClick(sender, e);
            // 테스트용 메시지 박스 소스
            MessageBox.Show(row.Cells["시군구"].Value.ToString() + " " + row.Cells["동"].Value.ToString() + " " + row.Cells["아파트"].Value.ToString());
        }
        private DataGridViewRow CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return (DataGridViewRow)(((DataGridView)sender).Rows[e.RowIndex]);
        }

        //매매 탭이 활성화 됐을 때 지도를 보여주는 이벤트
        private void tabPage_sell_view_Enter(object sender, EventArgs e)
        {
            this.Focus();
            map.TopLevel = false;
            map.Dock = DockStyle.Fill;
            splitContainer_sell.Panel2.Controls.Add(map);
            map.Show();
        }

        //전세,임대 탭이  활성화 됐을 때 지도를 보여주는 이벤트
        private void tabPage_rent_view_Enter(object sender, EventArgs e)
        {
            this.Focus();
            map.TopLevel = false;
            map.Dock = DockStyle.Fill;
            splitContainer_rent.Panel2.Controls.Add(map);
            map.Show();
        }
        /*
        //매매 탭에서 선택한 행의 데이터를 인코딩해서 맵에 보내주는 이벤트
        private void dataGridView_sell_view_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CellContentClick(sender, e);
        }

        //전세임대 탭에서 선택한 행의 데이터를 인코딩해서 맵에 보내주는 이벤트
        private void dataGridView_rent_view_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CellContentClick(sender, e);
        }
        */
        // DataGridView 안에서 클릭한 마우스의 위치와 그 셀의 값을 가지고 문자열을 만들어 URL로 넘어감
        private void CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            // 행의 제목값을 선택할 경우 예외처리
            try
            {
                row = (DataGridViewRow)(((DataGridView)sender).Rows[e.RowIndex]);
                // 선택한 데이터의 동, 아파트 이름 반환
                string dong = row.Cells["동"].Value.ToString();
                string apt = row.Cells["아파트"].Value.ToString();

                // 맵의 함수를 호출해서 새로운 맵 생성
                map.Show_keyword(dong + apt);
            }
            catch (ArgumentOutOfRangeException aoe)
            {

            }
        }
        // 배너 클릭 시 학교 홈페이지 접속
        private void bottom_panel_banner_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.bible.ac.kr/");

            } catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
