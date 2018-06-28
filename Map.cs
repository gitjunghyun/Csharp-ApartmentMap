using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//크롬브라우저를 사용하기 위해 사용
using CefSharp;
using CefSharp.WinForms;
//문자열을 url로 바꿔주기 위해 사용
using System.Net;

namespace TeamProject1
{
    public partial class Map : Form
    {
        // 비주얼 스튜디오 기본 내장 브라우저에서 자바스크립트 실행 오류
        // 비주얼 스튜디오에서 제공하는 내장 브라우저는 이클립스와 다르게 변경 불가 ㅡㅡ;
        // 어쩔 수 없이 기본 웹브라우저 도구 대신에 크롬 솔루션 패키지?를 다운 받아서 사용
        // 솔루션 구성 관리자 플랫폼을 Any CPU -> x64 or x86으로 새로 만들어서 실행해야 사용 가능
        public ChromiumWebBrowser browser1; // 기본 지도
        public ChromiumWebBrowser browser2; // 파라미터 url

        // 키워드를 받을 문장 선언
        public string keyword;
        string testURL = "http://localhost:8080//map/map.html"; // 테스트용 로컬 URL
        string str = "https://seokrae.github.io/MapCluster/WebContent/index"; // 깃허브 서버 URL
        string extention = ".html";
        public Map()
        {
            InitializeComponent();

            //윈도우테두리제거방법
            this.FormBorderStyle = FormBorderStyle.None;
            // 크롬 세팅과 초기화
            Cef.Initialize(new CefSettings());

            // url에는 api를 받아온 html 파일의 url사용
            // 웹상에서 보여주기 때문에 로컬주소에서 웹서버 타고 접속
            // url 뒤에 인코딩한 키워드를 추가
            
            browser1 = new ChromiumWebBrowser(str + extention);
            this.Controls.Add(browser1);
            browser1.Dock = DockStyle.Fill;
        }

        //키워드를 받아와서 맵을 바꿔주는 함수
        public void Show_keyword(string s)
        {
            //원래있던 지도 삭제
            this.Controls.Remove(browser1);

            //호출로 받아온 값을 변수에 저장
            keyword = WebUtility.UrlEncode(s);

            //새로운 맵 생성
            browser1 = new ChromiumWebBrowser(str + 2 + extention + "?key=" + keyword);
            this.Controls.Add(browser1);
            browser1.Dock = DockStyle.Fill;
        }
    }
}
