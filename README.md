# 2022년도 2학기 게임 소프트웨어 개인과제

이름: 이세희 / 학번: 20191987 / 학과: 산림환경시스템학과

## 1. 개인프로젝트 Github 저장소

- <https://github.com/Sehee-Lee-01/2022_2_GS>

## 2. 구현 현황

### 0) 실행환경

- 유니티 버전: `2021.3.9f1`

- 기타사항

  - `SampleScene`, `ParticleScene`, `TerrainScene`, `BackgroundScene`으로 분리하여  Scene을 구성
  - `git & github`를 통한 버전관리
  - `git issue`를 통한 프로젝트 이슈관리

### 1) SampleScene

![겜소 개인](https://user-images.githubusercontent.com/85275893/199090101-0a415754-82f2-43fb-8c3a-6a59ef4180aa.png)

- Scene 파일 경로: Assets/Scenes/SampleScene

- 사용 에셋: Assets/PolygonStarter/Prefabs/`SM_PolygonPrototype_Prop_Cone_01`
  
- C# 스크립트: Assets/`CubeGravity.cs`

    ```C#
    // Assets/CubeGravity.cs
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class CubeGravity : MonoBehaviour
    {
        public Rigidbody myRigidbody; // 컴포넌트 가져오기
        void Start()
        {
            myRigidbody.useGravity = true; // 값 변경
        }
    }
    ```

- 기능 1

  - `(구현완료)` 3D Object Shpere 추가하고 해당 Shpere에 Prefab 활용하여 다양한 모습(차, 비행기 등)으로 변경

  - `(구현완료)` Asset Store에서 Shpere에 반영할 Asset을 import 하고 import한 prefab을 Shpere에 적용

- 기능 2

  - `(구현완료)` 변수로 Cube 오브젝트를 제어하는 것으로 Cube와 Plane(바닥)을 생성하고 Cube에 Rigidbody 컴포넌트를 추가

  - `(구현완료)` 속성창에서 Rigidbody 컴포넌트의 Use Gravity는 체크하지 않고 Gravity는 false 로 설정

  - `(구현완료)` Cube 스크립트에서 Rigidbody 컴포넌트 선언하고 Rigidbody의 method를 활용하여 false로 초기화된 Gravity를 true로 변경

  - `(구현완료)` Cube는 Plane(바닥) 보다는 위쪽에 위치하도록 Y축 값으로 설정

  - `(구현완료)` 실행 버튼을 클릭하여 게임창에서 Cube가 중력을 받고 내려가서 Plane(바닥)에 떨어지는지 확인

### 2) ParticleScene

- Scene 파일 경로: Assets/Scenes/ParticleScene

- `(구현완료)` Particle System을 추가하고 속성값 5개 이상 변경하여 반영

- 변경된 속성값

  -
  -
  -
  -
  -  

### 3) TerrainScene

![겜소 개인 (1)](https://user-images.githubusercontent.com/85275893/199090121-728bdf21-e65f-48fd-96aa-f3cf89c57c46.png)

- Scene 파일 경로: Assets/Scenes/TerrainScene

- 사용 에셋

  - 텍스쳐
    - Assets/Ground textures pack/`Grass 05/diffuse`
    - Assets/Ground textures pack/`Ground 01/diffuse`
    - Assets/Ground textures pack/`Ground 02/diffuse`
  - 나무: Assets/Standard Assets/Environment/SpeedTree/Broadleaf/`Broadleaf_Desktop`
  - 잔디: Assets/Standard Assets/Environment/TerrainAssets/BillboardTextures/`GrassFrond01AlbedoAlpha`

- `(구현완료)` 3D Object로 Terrain을 추가하고 표면(Layer) Texture 변경, Brush로 산, 언덕 만들고
    나무, 잔디, Wind zone 추가

### 4) BackgroundScene

- Scene 파일 경로: Assets/Scenes/BackgroundScene

- 사용 에셋

  - 배경: Assets/Assets/UnderwaterFantasy/underwater-artwork/`underwater-fantasy-preview.png`
  - 오브젝트: Assets/PolygonStarter/Prefabs/`SM_Generic_Tree_02.prefab`

    ※ Wrap Mode를 Cramp에서Repeat로 변경

- 매터리얼 : Assets/`Mat_Background.mat`

- C# 스크립트: Assets/`Background.cs`

  ```c#
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;

  public class Background : MonoBehaviour
  {
      public Material bgMaterial; // 배경 매터리얼
      public float scrollSpeed = 0.2f; // 스크롤 속도

      // Update is called once per frame
      void Update()
      {
          Vector2 direction = Vector2.right; // 오른쪽으로 스크롤하도록 지정
          bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
      }
  }
  ```

- `(구현완료)` 스크롤되는 배경화면 만들기
