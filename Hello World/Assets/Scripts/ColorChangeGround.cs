using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;

public class ColorChangeGround : NetworkBehaviour
{

    Renderer rend;
    Color groundColor;
 /*   // Update is called once per frame
    void Update()
    {
        if 
        rend.material.SetColor("Color", Random.ColorHSV());
    }
 */

    public NetworkVariableColor color = new NetworkVariableColor(new NetworkVariableSettings
    {
        WritePermission = NetworkVariablePermission.ServerOnly,
        ReadPermission = NetworkVariablePermission.Everyone
    });

    public override void NetworkStart()
    {
        ColorChange();
    }

    public void ColorChange()
    {
        if (NetworkManager.Singleton.IsServer)
        {
             
            rend = GetComponent<Renderer>();
            rend.material.SetColor("rcolor", Random.ColorHSV());
            //    groundColor = gameObject.GetComponent<MeshRenderer>().material.color;
           // groundColor = ;




        }
        else
        {
       //     SubmitColorRequestServerRpc();
        }
    }
    /*
    [ServerRpc]
    void SubmitColorRequestServerRpc(ServerRpcParams rpcParams = default)
    {
        rend = GetComponent<Renderer>();
        
    }



    static GetColor()
    {
        return new Vector3(Random.Range(-3f, 3f), 1f, Random.Range(-3f, 3f));
    }

    void Update()
    {
        transform.position = Position.Value;

    }
    */
}
