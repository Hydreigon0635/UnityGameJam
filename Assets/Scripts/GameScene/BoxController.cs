using UnityEngine;

public class BoxController : MonoBehaviour
{
    public float thresholdAngle = 15f; // 箱の角度の閾値
    public bool isBoxOpen = false; // 箱が開いているかどうかのフラグ

    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトが球であるか確認します
        if (collision.gameObject.CompareTag("Player"))
        {
            // 箱のZ軸の角度を取得します
            float boxZRotation = transform.eulerAngles.z;

            // 箱の角度が閾値内にある場合
            if (Mathf.Abs(boxZRotation - 15f) < thresholdAngle)
            {
                isBoxOpen = false; // フラグをtrueに設定します
            }
            else
            {
                isBoxOpen = true; // フラグをfalseに設定します
                Destroy(gameObject); // 箱を破壊します
            }
        }
    }
}
