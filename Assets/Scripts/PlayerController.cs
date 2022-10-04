using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalloweenGame.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float speed = 5f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            GetComponent<CharacterController>().Move(movement * speed * Time.deltaTime);
        }
    }
}