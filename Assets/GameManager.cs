using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ghost[] ghosts; //��Ʈ�� ������

    public Pacman pacman;

    public Transform pallets;

    public int score { get; private set; }

    public int lives { get; private set; }


    private void Start()
    {
        NewGame();
    }
    //�ƹ�Ű�� ������ �� �ٽý���.
    private void Update()
    {
        if (this.lives <= 0 && Input.anyKeyDown) {
            NewGame();
            
        }
    }

    private void NewGame()
    {
        SetScore(0);
        SetLives(3);
        NewRound();
    }

    private void NewRound()
    {
        foreach(Transform pellet in this.pallets){
            pellet.gameObject.SetActive(true);
        }

        ResetState();
    }

    private void ResetState()
    {
        for (int i = 0; i < this.ghosts.Length; i++)
        {
            this.ghosts[i].gameObject.SetActive(true);
        }
        this.pacman,gameObject.SetActive(true);

    }
    //�Ѹ��� ��Ƹ����� �� ���ӿ���.
    private void GameOver()
    {
        for (int i = 0; i < this.ghosts.Length; i++)
        {
            this.ghosts[i].gameObject.SetActive(false);
        }
        this.pacman,gameObject.SetActive(false);
    }

    private void SetScore(int score)
    {
        this.score = score;
    }

    private void SetLives(int lives)
    {
        this.lives = lives;
    }

    //��Ʈ�� �Ծ����� �߰�����.
    public void GhostEaten(Ghost ghost)
    {
        SetScore(this.score + ghost.points);
    }
    //�Ѹ��� ��� ������ ��
    //1.����� 0������ ������ ����� 1���� �پ��� �ٽý���.(3�� �ڿ� �ٽ� ����)
    //2.����� 0�� ���ϸ� ���ӿ���.
    public void PacmanEaten()
    {
        this.pacman.gameObject.SetActive(false);

        SetLives(this.lives - 1);
        if(this lives > 0){
            Invoke(nameof(ResetState), 3.0f);
        }else
        {
            GameOver();
        }
    }
}

