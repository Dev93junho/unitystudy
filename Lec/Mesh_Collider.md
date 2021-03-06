## 복잡형상 Model Import와 Mesh Collider

#### Preview
- 모델 임포트는 .fbx와 .obj 형식의 모델링 파일을 이용함
- 모델 제작은 개인적인 경험으로 익숙한 [Onshape](https://www.onshape.com/en/)를 통해 제작하였음

#### Modelling
1. 이번 [Yachoo](https://github.com/MinTpie30/unitystudy/tree/master/Yachooo) 프로젝트 를 통해서 구현할 모델들은 Unity에서 기본적으로 제공해주는 도형만으로는 제작하기가 힘들었다. 그래서 외부 모델링 프로그램을 통해서 제작해 사용하는 것이 좋다고 판단했다.

2. 모델링은 Blender를 많이 쓰는 것으로 알고있으나, 학부시절 전공특성상 CAD를 자주 사용했던 경험을 통해 별도의 설치가 필요없는 클라우드형 CAD인 Onshape를 통해 제작하기로 결정했다.

3. Onshape는 model Export시 다양한 확장자로 지원해준다. 그중에 obj형식을 지원해줘 해당 확장자로 다운을 받았고, 실험을 위해 converting 사이트를 통해 fbx형식을 받아 두가지를 모두 이용해 보았다.

![models](./unitystudy/Yachooo/Assets/dice_and_cup.PNG)

#### Mesh Collider
- Mesh Collider는 box, capsule, Cylinder Collider 처럼 물리 충돌처리를 위한 Component이며, 특히 세밀한 충돌 감지의 경우 사용된다.

- box, capsule, Cylinder 형상으로 정의하기 힘든 경우, Mesh Collider를 사용하면 된다.

- 다만 형상 중 볼록한 부분은 정확히 인식이 가능하나, 오목한 부분은 mesh 인식이 안되는 편이다.

- CPU 부하가 가장 높은 Collider이기 때문에 정말 필요한 경우가 아니면 사용하지 않는 편이다.
