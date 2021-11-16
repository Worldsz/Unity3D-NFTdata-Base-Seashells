using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace nmxi.easylogview{
    public class EasyLogView : MonoBehaviour {
        [SerializeField]
        private TextMeshProUGUI m_textUI;
        [SerializeField] private Scrollbar _bar;
        private void Awake(){
            m_textUI = GetComponent<TextMeshProUGUI>();
            Application.logMessageReceived += OnLogMessage;
            
            m_textUI.text = String.Empty;
        }

        private void OnDestroy()
        {
            Application.logMessageReceived -= OnLogMessage;
        }

        private void OnLogMessage( string i_logText, string i_stackTrace, LogType type )
        {
            var tmp = m_textUI.text;
            m_textUI.text = "[" + DateTime.Now.ToLongTimeString() + "] ";
            switch (type){
                case LogType.Warning:
                    m_textUI.text += "<color=#ffff00>" + i_logText + "</color>" + Environment.NewLine;
                    break;
                case LogType.Error:
                    m_textUI.text += "<color=#ff0000>" + i_logText + "</color>" + Environment.NewLine;
                    break;
                default:
                    m_textUI.text += i_logText + Environment.NewLine;
                    break;
            }
            m_textUI.text += tmp;
            _bar.value = 1;
        }

        public void ResetLog(){
            m_textUI.text = "[" + DateTime.Now.ToLongTimeString() + "] Clear log";
        }
    }
}
