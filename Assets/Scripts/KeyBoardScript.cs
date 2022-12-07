using UnityEngine;

public class KeyBoardScript : MonoBehaviour
{
    [SerializeField] private WordManager _wordManager;

  
    public void A_Click()
    {
        char click = 'A';
        _wordManager.AddToString(click);
    }
    public void B_Click()
    {
        char click = 'B';
        _wordManager.AddToString(click);
    }
    public void C_Click()
    {
        char click = 'C';
        _wordManager.AddToString(click);
    }
    public void D_Click()
    {
        char click = 'D';
        _wordManager.AddToString(click);
    }
    public void E_Click()
    {
        char click = 'E';
        _wordManager.AddToString(click);
    }
    public void F_Click()
    {
        char click = 'F';
        _wordManager.AddToString(click);
    }
    public void G_Click()
    {
        char click = 'G';
        _wordManager.AddToString(click);
    }
    public void H_Click()
    {
        char click = 'H';
        _wordManager.AddToString(click);
    }
    public void I_Click()
    {
        char click = 'I';
        _wordManager.AddToString(click);
    }
    public void J_Click()
    {
        char click = 'J';
        _wordManager.AddToString(click);
    }
    public void K_Click()
    {
        char click = 'K';
        _wordManager.AddToString(click);
    }
    public void L_Click()
    {
        char click = 'L';
        _wordManager.AddToString(click);
    }
    public void M_Click()
    {
        char click = 'M';
        _wordManager.AddToString(click);
    }
    public void N_Click()
    {
        char click = 'N';
        _wordManager.AddToString(click);
    }
    public void O_Click()
    {
        char click = 'O';
        _wordManager.AddToString(click);
    }
    public void P_Click()
    {
        char click = 'P';
        _wordManager.AddToString(click);
    }
    public void Q_Click()
    {
        char click = 'Q';
        _wordManager.AddToString(click);
    }
    public void R_Click()
    {
        char click = 'R';
        _wordManager.AddToString(click);
    }
    public void S_Click()
    {
        char click = 'S';
        _wordManager.AddToString(click);
    }
    public void T_Click()
    {
        char click = 'T';
        _wordManager.AddToString(click);
    }
    public void U_Click()
    {
        char click = 'U';
        _wordManager.AddToString(click);
    }
    public void V_Click()
    {
        char click = 'V';
        _wordManager.AddToString(click);
    }
    public void W_Click()
    {
        char click = 'W';
        _wordManager.AddToString(click);
    }
    public void X_Click()
    {
        char click = 'X';
        _wordManager.AddToString(click);
    }
    public void Y_Click()
    {
        char click = 'Y';
        _wordManager.AddToString(click);
    }
    public void Z_Click()
    {
        char click = 'Z';
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
