using UnityEngine;
using UnityEngine.UI;
 namespace DllTestAssembly.View
{
    public class UIShowInfoView : MonoBehaviour
    {
        public Text text;
        private void Start()
        {
            string gg = @" 
             购买 时代峰峻卡兰蒂斯房间是否卡兰,
             购买 时代峰峻卡兰蒂斯房间是否卡兰
             购买 时代峰峻卡兰蒂斯房间是否卡兰
             购买 时代峰峻卡兰蒂斯房间是否卡兰";
            text.text = "展示界面";
            this.transform.Find("Content").GetComponent<Text>().text = gg;
          
        }
    }
}
