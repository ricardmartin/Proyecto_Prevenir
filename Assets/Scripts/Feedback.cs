using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feedback : MonoBehaviour
{
    private Button _btnSeleccionado;
    public Button _btnAModificar1;
    public Button _btnAModificar2;
    public Text _txtFeedback;
    public int _Contador;
    public bool _NoRima;

    void Start()
    {
        
        _btnSeleccionado = GetComponent<Button>();
        _btnSeleccionado.onClick.AddListener(() =>
        {
            if (_NoRima == true)
            {
                _txtFeedback.text = "Correcte";
                

                switch (_Contador)
                {
                    case 0:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                        _Contador++;                                             
                        break;
                    case 1:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _Contador++;
                        break;
                    case 2:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _Contador++;
                        break;
                    case 3:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/jirafa");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/jirafa");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/jirafa");
                        _Contador++;
                        break;

                    case 4:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/PlaySoccer");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/PlaySoccer");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/PlaySoccer");
                        _Contador++;
                        break;
                    case 5:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/pala");
                        _Contador++;
                        break;
                    case 6:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _Contador++;
                        break;
                    case 7:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _Contador++;
                        break;
                    case 8:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/jirafa");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/jirafa");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/jirafa");
                        _Contador++;
                        break;
                    case 9:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/PlaySoccer");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/PlaySoccer");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/PlaySoccer");
                        _Contador++;
                        break;
                    case 10:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/patata");
                        _Contador++;
                        break;
                    case 11:
                        _btnSeleccionado.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _btnAModificar1.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _btnAModificar2.image.sprite = Resources.Load<Sprite>("Sprites/hormiga");
                        _Contador++;
                        break;
                    case 12:
                        _btnSeleccionado.gameObject.SetActive(false);
                        _btnAModificar1.gameObject.SetActive(false);
                        _btnAModificar2.gameObject.SetActive(false);
                        _Contador++;
                        break;
                    default:
                        break;
                }
                _txtFeedback.text = _Contador.ToString();

            }
            else
            {
                _txtFeedback.text = "Incorrecte";
               
            }
                      
        });

    }
}
