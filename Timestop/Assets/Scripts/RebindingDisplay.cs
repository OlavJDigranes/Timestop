using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro; 

public class RebindingDisplay : MonoBehaviour
{
    [SerializeField] private InputActionReference jump = null;
    [SerializeField] private InputActionReference move = null;
    [SerializeField] private InputActionReference place = null;
    [SerializeField] private PlayerController playerController = null;
    [SerializeField] private TMP_Text bindingDispTxt = null;
    [SerializeField] private GameObject startRebindObj = null;
    [SerializeField] private GameObject waitingForInputObj = null;

    private InputActionRebindingExtensions.RebindingOperation rebOp1;
    private InputActionRebindingExtensions.RebindingOperation rebOp2;
    private InputActionRebindingExtensions.RebindingOperation rebOp3;

    public void StartRebinding()
    {
        startRebindObj.SetActive(false);
        waitingForInputObj.SetActive(true);

        playerController.PlayerInput.SwitchCurrentActionMap("Menu");

        rebOp1 = jump.action.PerformInteractiveRebinding().WithControlsExcluding("Mouse").OnMatchWaitForAnother(0.1f).OnComplete(operation => RebindComplete()).Start();
        rebOp2 = move.action.PerformInteractiveRebinding().WithControlsExcluding("Mouse").OnMatchWaitForAnother(0.1f).OnComplete(operation => RebindComplete()).Start();
        rebOp3 = place.action.PerformInteractiveRebinding().WithControlsExcluding("Mouse").OnMatchWaitForAnother(0.1f).OnComplete(operation => RebindComplete()).Start();
    }

    private void RebindComplete()
    {
        rebOp.Dispose();

        startRebindObj.SetActive(true);
        waitingForInputObj.SetActive(false);

        playerController.PlayerInput.SwitchCurrentActionMap("Menu");
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
