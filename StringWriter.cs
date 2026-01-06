using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;

public class StringWriter
{
    private string inputText;

    private TextMeshProUGUI textObject;

    private StringBuilder sb;

    private int ind = 0;

    /// <summary>
    /// Constructs the String Writer with the given params.
    /// </summary>
    /// <param name="textObject">The TextMeshProUGUI object, which gets edited when starting the writer in this class.</param>
    /// <param name="inputText">The text which should be written</param>
    public StringWriter(TextMeshProUGUI textObject, string inputText)
    {
        this.inputText = inputText;
        this.textObject = textObject;

        sb = new StringBuilder();
    }

    /// <summary>
    /// Writes the text to the in the constructor given object.
    /// </summary>
    /// <param name="writeSpeed">This speed in seconds is used to write the text. (Default is 0.1s)</param>
    /// <returns>Nothing</returns>
    internal IEnumerator writer(float writeSpeed=0.1f)
    {
        while(ind < inputText.Length)
        {
            yield return new WaitForSeconds(writeSpeed);

            sb.Append(inputText[ind]);
            textObject.text = sb.ToString();
            //Debug.Log(sb.ToString());

            ind++;
        }
        Debug.Log("Successfully finished writing the text!");
    }
}