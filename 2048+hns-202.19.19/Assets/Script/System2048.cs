using UnityEngine;
using System.Linq;

/// <summary>
/// 2048 �t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048 : MonoBehaviour
{
    #region ���:���}
    [Header("�ťհ϶�")]
    public Transform[] blocksEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;
    #endregion

    #region ���:�p�H
    // �p�H�����ܦb�ݩʭ��O�W
    [SerializeField]
    private Direction direction;
    /// <summary>
    /// �Ҧ��϶����
    /// </summary>
    private BlockData[,] blocks = new BlockData[4, 4];

    /// <summary>
    /// ���U�y��
    /// </summary>
    private Vector3 posDown;
    /// <summary>
    /// ��}�y��
    /// </summary>
    private Vector3 posUp;
    /// <summary>
    /// �ϧ_���U����
    /// </summary>
    private bool isClickMouse;
    #endregion

    #region �ƥ�
    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        CheckDirection();
    }
    #endregion

    #region ��k:�p�H

    /// <summary>
    /// ��l�Ƹ��
    /// </summary>
    private void Initialize()
    {
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                blocks[i, j] = new BlockData();
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = blocksEmpty[i * blocks.GetLength(1) + j].position;
            }
        }

        PrintBlockData();
        CreateRandomNumberBlock();
        CreateRandomNumberBlock();
    }

    private void PrintBlockData() 
    {
        string result = "";

        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                // �s�� �B�Ʀr�P�y��
                // �s���B�Ʀr�P����
                // �T���B��l
                // �y�k:���L�� ? �� A : �� B ;
                // ���L�Ȭ� ture ���G�� �� A
                // ���L�Ȭ� false ���G�� �� B
                result += "�s��" + blocks[i, j].v2Index + "<color=red>�Ʀr:" + blocks[i, j].number + "</color> <color=yellow>" + (blocks[i,j].goBlock ? "��" : "�@") + "</color> |";
            }

            result += "\n";
        }

        print(result);
    }

    /// <summary>
    /// �إ��H���Ʀr�϶�
    /// �P�_�Ҧ��϶����S���Ʀr���϶� - �Ʀr���s
    /// �H���D��@��
    /// �ͦ��Ʀr���Ӱ϶���
    /// </summary>
    private void CreateRandomNumberBlock()
    {
        var equalZero =
            from BlockData data in blocks
            where data.number == 0
            select data;

        print("���s����Ʀ��X��:" + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("�H���s��:" + randomIndex);

        // ��X�H���϶� �s��
        BlockData dataRandom = blocks[equalZero.ToArray()[randomIndex].v2Index.x, equalZero.ToArray()[randomIndex].v2Index.y];
        // �N�Ʀr 2 
        dataRandom.number = 2;


        // ��Ҥ�-�ͦ�(����A������)
        GameObject tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        // �ͦ��϶� ���w�y��
        tempBlock.transform.position = dataRandom.v2Position;
        // �x�s �ͦ��϶� ���
        dataRandom.goBlock = tempBlock;

        PrintBlockData();
        
    }

    /// <summary>
    /// �ˬd��V
    /// </summary>
    private void CheckDirection() 
    {
        #region ��L

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Direction.Up;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Direction.Down;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Direction.Left;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Direction.Right;
            CheckAndMoveBlock();
        }
        #endregion

        #region �ƹ��PĲ��
        if (!isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = true;
            posDown = Input.mousePosition;
            print("���U�y��:" + posDown);
        }
        else if (isClickMouse && Input.GetKeyUp(KeyCode.Mouse0))
        {
            isClickMouse = false;
            posUp = Input.mousePosition;
            print("��}�y��:" + posUp);

            // 1. �p��V�q�� ��}�y�� - ���U�y��
            Vector3 directionValue = posUp - posDown;
            print("�V�q��:" + directionValue);
            // 2. �ഫ�� 0 ~ 1 ��
            print("�ഫ���:" + directionValue.normalized);

            // ��V X �P Y �������
            float xAbs = Mathf.Abs(directionValue.normalized.x);
            float yAbs = Mathf.Abs(directionValue.normalized.y);
            // X > Y ������V
            if (xAbs > yAbs)
            {
                if (directionValue.normalized.x > 0) direction = Direction.Right;
                else direction = Direction.Left;
                CheckAndMoveBlock();
            }
            // Y > X ������V
            else if (yAbs > xAbs)
            {
                if (directionValue.normalized.y > 0) direction = Direction.Up;
                else direction = Direction.Down;
                CheckAndMoveBlock();
            }
        }

        #endregion
    }
    private void CheckAndMoveBlock()
    {
        print("�ثe����V:" + direction);

        switch (direction)
        {
            case Direction.Right:
                break;
            case Direction.Left:
                print("��V������");
                break;
            case Direction.Up:
                break;
            case Direction.Down:
                break;
        }
    }
    #endregion
}



/// <summary>
/// �϶����
/// �C�Ӱ϶��C������B�y�СB�s���B�Ʀr
/// </summary>
public class BlockData
{
    /// <summary>
    /// �϶����Ʀr����
    /// </summary>
    public GameObject goBlock;
    /// <summary>
    /// �϶��y��
    /// </summary>
    public Vector2 v2Position;
    /// <summary>
    /// �϶��s��:�G���}�C�����s��
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// �϶��Ʀr:�w�]�� 0 , �Ϊ� 2�B4�B8......2048
    /// </summary>
    public int number;
}

public enum Direction 
{
    None, Right, Left, Up, Down
}