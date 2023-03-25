using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using Newtonsoft.Json;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayFabManager : MonoBehaviour
{   
    [Header ("UI")]
    public TMP_Text messageText;
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;

    // TODO || REGISTRO DE USUARIO  ||
    public void RegisterButton()
    {   
        //Parámetro para la contraseña
        if(passwordInput.text.Length < 6)
        {
            messageText.text = "The password must be at least 6 characters long.";
            return;
        }

        //Datos para el nuevo usuario
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false   //No requiere un nombre de usuario
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError); //Se envía la solicitud a la Api
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Register and logged in!";
    }

    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
    }

    // TODO || LOGUEO DE USUARIO  ||
    public void LoginButton()
    {
        //Datos para el login
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError); //Se envía la solicitud a la Api
    }

    void OnLoginSuccess(LoginResult result)
    {
        messageText.text = "Logged in!";
        StartCoroutine("LoadLevel");
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level");        //Cargará la escena del nivel si logra ingresar
    }

    // TODO || RECUPERACIÓN DE USUARIO  ||
    public void ResetPasswordButton()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "99AC8"          //Este es el ID de la bd creada en PlayFab llamada Collector
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }

    void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {   
        messageText.text = "Password reset mail sent!";
    }
}