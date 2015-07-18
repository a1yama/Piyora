using UnityEngine;
using System.Collections;

public class Piyo : MonoBehaviour {

    public GameObject piyoPrefab;
    public Sprite[] piyoSprites;
    private float spd = 2;

	// Use this for initialization
	void Start () {
        StartCoroutine(showPiyo(100));
	}

    void Update() {
        if (Input.GetMouseButtonDown(0)) {

            Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

            if (aCollider2d) {
                GameObject obj = aCollider2d.transform.gameObject;
                Destroy(obj);
            }
        }
    }
    IEnumerator showPiyo(int count) {
        for (int i = 0; i < count; i++) {
            float dir = Random.Range(0, 359);
            Vector2 pos = new Vector2(0, 0);
            GameObject piyo = Instantiate(piyoPrefab, pos, Quaternion.AngleAxis(0, Vector3.forward)) as GameObject;
            int spriteId = Random.Range(1, 5);
            piyo.name = "Piyo" + spriteId;
            SpriteRenderer spriteObj = piyo.GetComponent<SpriteRenderer>();
            spriteObj.sprite = piyoSprites[spriteId];
            yield return new WaitForSeconds(0.5f);
        }
    }
}
