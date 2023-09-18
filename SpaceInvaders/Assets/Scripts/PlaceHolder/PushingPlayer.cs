using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingPlayer : MonoBehaviour {
    public enum whereMov {
        minusX, minusZ, plusX, plusZ
    };
    public whereMov wherePush;
    /*
    private void OnCollisionEnter(Collision collision) {

        GameObject player = collision.gameObject;
        //Debug.Log(player.transform.position.x);
        if (player.name == "Player") {
            Vector3 playerPosition = new Vector3(0, 0, 0);
            playerPosition = player.transform.position;
            if (wherePush == whereMov.minusX) {
                playerPosition.x = 22.2f;
            }
            //else if(wherePush == )
            else if (wherePush == whereMov.minusZ) {
                playerPosition.z = -16.7f;
            }
            else if (wherePush == whereMov.plusX) {
                playerPosition.x = -2f;
            }
            else if (wherePush == whereMov.plusZ) {
                playerPosition.z = -22.2f;
            }
            player.transform.position = playerPosition;
        }
    }
    */

    private void OnCollisionStay(Collision collision) {
        GameObject player = collision.gameObject;
        //Debug.Log(player.transform.position.x);
        if (player.name == "Player") {
            Vector3 playerPosition = new Vector3(0, 0, 0);
            playerPosition = player.transform.position;
            if (wherePush == whereMov.minusX) {
                playerPosition.x = 22.2f;
            }
            //else if(wherePush == )
            else if (wherePush == whereMov.minusZ) {
                playerPosition.z = -16.7f;
            }
            else if (wherePush == whereMov.plusX) {
                playerPosition.x = -2f;
            }
            else if (wherePush == whereMov.plusZ) {
                playerPosition.z = -22.2f;
            }
            player.transform.position = playerPosition;
        }
    }

}
