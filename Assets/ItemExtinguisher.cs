using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemExtinguisher : MonoBehaviour {

	// MainCameraオブジェクトを入れる
	private GameObject mainCamera;

	// Use this for initialization
	void Start () {
		// MainCameraオブジェクト取得
		this.mainCamera = GameObject.Find ("Main Camera");

		// 衝突判定用壁オブジェクトをMeinCameraのすぐ後ろに配置
		this.transform.position = new Vector3 (0, this.transform.position.y, mainCamera.transform.position.z - 1);
				
	}
	
	// Update is called once per frame
	void Update () {
		// 衝突安定用壁オブジェクトがMainCameraの動きに追従
		this.transform.position = new Vector3 (0, this.transform.position.y, mainCamera.transform.position.z - 1);

	}

	void OnTriggerEnter(Collider other) {
		// 接触したゲームオブジェクトを破棄(MainCameraから見えなくなったアイテムを順次破棄)
		Destroy(other.gameObject);

	}


}
