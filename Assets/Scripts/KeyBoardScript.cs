using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoardScript : MonoBehaviour
{
    [SerializeField] private WordManager _wordManager;

  
    public void A_Click()
    {
        char click = 'a';
        _wordManager.AddToString(click);
    }
    public void B_Click()
    {
        char click = 'b';
        _wordManager.AddToString(click);
    }
    public void C_Click()
    {
        char click = 'c';
        _wordManager.AddToString(click);
    }
    public void D_Click()
    {
        char click = 'd';
        _wordManager.AddToString(click);
    }
    public void E_Click()
    {
        char click = 'e';
        _wordManager.AddToString(click);
    }
    public void F_Click()
    {
        char click = 'f';
        _wordManager.AddToString(click);
    }
    public void G_Click()
    {
        char click = 'g';
        _wordManager.AddToString(click);
    }
    public void H_Click()
    {
        char click = 'h';
        _wordManager.AddToString(click);
    }
    public void I_Click()
    {
        char click = 'i';
        _wordManager.AddToString(click);
    }
    public void J_Click()
    {
        char click = 'j';
        _wordManager.AddToString(click);
    }
    public void K_Click()
    {
        char click = 'k';
        _wordManager.AddToString(click);
    }
    public void L_Click()
    {
        char click = 'l';
        _wordManager.AddToString(click);
    }
    public void M_Click()
    {
        char click = 'm';
        _wordManager.AddToString(click);
    }
    public void N_Click()
    {
        char click = 'n';
        _wordManager.AddToString(click);
    }
    public void O_Click()
    {
        char click = 'o';
        _wordManager.AddToString(click);
    }
    public void P_Click()
    {
        char click = 'p';
        _wordManager.AddToString(click);
    }
    public void Q_Click()
    {
        char click = 'q';
        _wordManager.AddToString(click);
    }
    public void R_Click()
    {
        char click = 'r';
        _wordManager.AddToString(click);
    }
    public void S_Click()
    {
        char click = 's';
        _wordManager.AddToString(click);
    }
    public void T_Click()
    {
        char click = 't';
        _wordManager.AddToString(click);
    }
    public void U_Click()
    {
        char click = 'u';
        _wordManager.AddToString(click);
    }
    public void V_Click()
    {
        char click = 'v';
        _wordManager.AddToString(click);
    }
    public void W_Click()
    {
        char click = 'w';
        _wordManager.AddToString(click);
    }
    public void X_Click()
    {
        char click = 'x';
        _wordManager.AddToString(click);
    }
    public void Y_Click()
    {
        char click = 'y';
        _wordManager.AddToString(click);
    }
    public void Z_Click()
    {
        char click = 'z';
        _wordManager.AddToString(click);
    }

    public void DeleteClick()
    {
        _wordManager.RemoveFromString();
    }
    public void EnterClick()
    {
        _wordManager.EnterPressed();
    }
}
