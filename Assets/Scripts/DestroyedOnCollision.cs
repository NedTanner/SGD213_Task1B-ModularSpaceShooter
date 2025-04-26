using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TagListType
{
    Blacklist,
    Whitelist
}

public class DestroyedOnCollision : MonoBehaviour
{

    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    // Tag list to identify whether to destroy projectile
    [SerializeField]
    private List<string> tags;

    void OnTriggerEnter2D(Collider2D other)
    {
        bool tagInList = tags.Contains(other.gameObject.tag);

        if (tagListType == TagListType.Blacklist && tagInList)
        {
            // Destroy if collision is in Blacklist and the tag IS in the Blacklist
            Destroy(gameObject);
        }
        else if (tagListType == TagListType.Whitelist && !tagInList)
        {
            // Destroy if collision is in Whitelist and the tag is NOT in the Whitelist
            Destroy(gameObject);
        }
        else
        {
            // Use default collision code
        }
    }

    // Checks if object is enemy, destroy when object leaves screen if true
    void OnBecameInvisible()
    {
        if (gameObject.tag == "Enemy" || gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
