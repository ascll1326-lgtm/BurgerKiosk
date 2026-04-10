# (C# 코딩) 버거 키오스크
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자의 메뉴 선택에 따라 주문 내역과 총 금액을 보여주는 키오스크 프로그램
- 사용한 플랫폼:
- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
- Label, ListBox, Button, GroupBox, RadioButton, CheckBox
- 사용한 기술과 구현한 기능:
- RadioButton과 CheckBox를 이용하여 메뉴 선택 기능 구현
- ListBox와 Label을 이용하여 주문 내역과 총 금액 표시
- Button을 이용하여 주문 초기화 기능 구현
- 입력 검증을 통해 사용자가 메뉴를 선택하지 않았을 때 에러 메시지 표시





## 실행 화면 (과제1)
- 코드의 실행 스크린샷과 구현 내용 설명
![실행화면](img/screenshot-1.png)
![image](img/screenshot-3.png)
- 구현한 내용 (위 그림 참조)
	- RadioButton과 CheckBox 등을 적절히 배치하고  GroupBox로 적절하게 그룹어서 기본적인 UI를 구성
- 주문 내역과 총 금액을 List박스에 표시하도록 구현하였다.
- 초기화 버튼을 만들어 사용자가 다시 주문할 수 있도록 하였다.
- Tostring("N0")를 이용하여 가격의 가독성을 높혔다.





## 실행 화면 (과제2)
- 코드의 실행 스크린샷과 구현 내용 설명
![실행화면](img/screenshot-2.png)
- 구현한 내용 (위 그림 참조)
- 아무것도 선택하지 않았을 시 에러 메세지가 뜨도록 하였다.




