# 게임 소프트웨어

## 개인과제

* 유니티 버전(2021.3.9f1), 소스파일 문제로 유니티로 실행이 안되는 경우는 감점
* Readme.txt 파일, 소스파일 없는 경우 감점
* SampleScene, ParticleScene, TerrainScene, BackgroundScene 으로 분리하여
  Scene을 구성하지 않는 경우는 감점

## [SampleScene] - 5점

1. 3D Object Shpere 추가하고 해당 Shpere에 Prefab 활용하여 다양한 모습(차, 비행기 등)으로 변경
    Asset Store에서 Shpere에 반영할 Asset을 import 하고 import한 prefab을 Shpere에 적용 (2점)

2. 변수로 Cube 오브젝트를 제어하는 것으로 Cube와 Plane(바닥)을 생성하고 Cube에 Rigidbody 컴포넌트를 추가
    속성창에서 Rigidbody 컴포넌트의 Use Gravity는 체크하지 않고 Gravity는 false 로 설정
    Cube 스크립트에서 Rigidbody 컴포넌트 선언하고
    Rigidbody의 method를 활용하여 false로 초기화된 Gravity를 true로 변경
    Cube는 Plane(바닥) 보다는 위쪽에 위치하도록 Y축 값으로 설정
    실행 버튼을 클릭하여 게임창에서 Cube가 중력을 받고 내려가서 Plane(바닥)에 떨어지는지 확인 (3점)

## [ParticleScene] - 5점

1. Particle System을 추가하고 속성값 5개 이상 변경하여 반영 (5점)
    변경된 속성값은 Readme.txt 파일에 설명을 작성

## [TerrainScene] - 5점

1. 3D Object로 Terrain을 추가하고 표면(Layer) Texture 변경, Brush로 산, 언덕 만들고
    나무, 잔디, Wind zone 추가 (5점)

## [BackgroundScene] - 5점

1. 스크롤되는 배경화면 만들기 (5점)
    * 배경화면(Space Star Field Backgrounds)과 오브젝트(Awesome Cartoon Airplanes)는
       수업시간에 하지 않은 Asset으로 반영
    * Asset으로 Space Star Field Backgrounds, Awesome Cartoon Airplanes을 사용하는 경우와
       다른 학생과 동일한 Asset에 동일한 속성값 사용시 감점
