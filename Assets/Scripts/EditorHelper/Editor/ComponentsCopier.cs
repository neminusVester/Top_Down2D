using UnityEditor;
using UnityEngine;

public class ComponentsCopier : EditorWindow
{
    private static Component[] copiedComponents;

    [MenuItem("Tools/Components/Copy Components &C")]
    private static void Copy()
    {
        copiedComponents = Selection.activeGameObject.GetComponents<Component>();
    }

    [MenuItem("Tools/Components/Past Components &V")]
    private static void Paste()
    {
        foreach (var targetGameObject in Selection.gameObjects)
        {
            if (!targetGameObject || copiedComponents == null) continue;
            foreach (var copiedComponent in copiedComponents)
            {
                if (!copiedComponent) continue;
                UnityEditorInternal.ComponentUtility.CopyComponent(copiedComponent);
                UnityEditorInternal.ComponentUtility.PasteComponentAsNew(targetGameObject);
            }
        }
    }
}