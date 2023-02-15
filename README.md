# Unity3WeakPortfolio




## 오전 10:24 2023-02-13
## Feat : Project Init
## Detail :
###         - Import Packages : Spine Asset, URP Asset, 2D Asset, Sprite Shader Asset
###         - Directory Sorting : 임포트한 패키지들을 각 패키지 명 폴더로 따로 분류, Resources 폴더를 만들어 플레이어의 일부 리소스 추가 및 Directory 정리


## 오전 9:16 2023-02-14
## Feat : Player State구현
## Detail :
###         - StatePattern을 이용하여서 상태 구현 : 유니티의 State Machine을 사용하는 것 보다 코드의 가독성, 유지 보수, 확장에 유리할 것이라 판단되었고 추가적으로 몰랐던 내용을 학습, 도입 함으로써 
###            스스로의 기술 향상에 도움이 될것이라 판단하여서 사용


## Issue : Player State 구현 중 딜레이를 가지는 동작이 있어 코루틴과 관련한 이슈 발생
## Detail :
###         - 1. Player State란 클래스 파일을 새로 제작하여서 StatePattern을 구현함 이 과정에서 플레이어의 상태별로 Class를 만들어 주고 
###             Player의 클래스에서 해당 State클래스들의 공통 상속 시키는 인터페이스를 인스턴스화 해당 과정에서 State클래스들은 Unity의 MonoBehaviour를 상속하지 않게끔 설계하였는데
###             동작의 딜레이를 주기 위해 Coroutine함수를 이용하려 하던 중 StartCoroutine() 함수를 사용 할 수 없는 이슈가 발견
###         - 2. StartCoroutine() 함수는 MonoBehaviour를 상속을 받아야만 실행이 가능함
###         - 3. 해당 동작을 구현하기 위해서 StartCoroutine 클래스를 Player클래스에서 구현 혹은 Coroutine 함수를 실행하는 Handler Class를 싱글톤 패턴으로 구현하여서 
###             Coroutine함수를 실행하게끔 구현하면 해결될 것으로 보임

## 오후 2:36 2023-02-15
## Enemy의 이동을 구현하기 위한 A* 알고리즘 R&D, 관련 지식으로 ManhattanDistance Algorithm학습