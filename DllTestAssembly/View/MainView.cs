using UnityEngine;
using UnityEngine.UI;

namespace DllTestAssembly.View
{
    public class MainView : MonoBehaviour
    {
        public Button loadBtn;
        private void Start()
        {
            loadBtn = this.transform.Find("LoadBtn").GetComponent<Button>();
            loadBtn.onClick.AddListener(OnLoadBtnClick);
        }
        public void OnLoadBtnClick()
        {
            Debug.Log("OnLoadBtnClick");
            GameObject gm = Resources.Load("ShowInfoView", typeof(GameObject)) as GameObject;
            gm=GameObject.Instantiate(gm);
            gm.transform.SetParent(GameObject.Find("Canvas").transform);
            gm.transform.localPosition = Vector3.zero;
            gm.transform.localScale = Vector3.one;
        }
    }
}
