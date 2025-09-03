using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float controlspeed = 10f;
    [SerializeField] float xclamp = 25f;
    [SerializeField] float yclamp = 25f;

    [SerializeField] float controlRollfactor = 40f;
    [SerializeField] float rollSpeed = 25f;
    [SerializeField] float controlPitchfactor = 25f;
    Vector2 move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        translationmedium();
        rotationmedium();
    }

    private void translationmedium()
    {

        float xOffset = move.x * controlspeed * Time.deltaTime;
        float xrawpos = transform.localPosition.x + xOffset;
        float xclamping = Mathf.Clamp(xrawpos, -xclamp, xclamp);

        float yOffset = move.y * controlspeed * Time.deltaTime;
        float yrawpos = transform.localPosition.y + yOffset;
        float yclamping = Mathf.Clamp(yrawpos, -yclamp, yclamp);

        transform.localPosition = new Vector3(xclamping, yclamping, 0f);
    }

    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
    public void rotationmedium()
    {
        float pitch = -controlPitchfactor * move.y;
        float roll = -controlRollfactor * move.x;
        Quaternion targetedRotation = Quaternion.Euler(pitch, 0f,roll);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetedRotation, rollSpeed *Time.deltaTime);
    }
}
