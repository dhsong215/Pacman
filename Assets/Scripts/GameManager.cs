using UnityEngine;
public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public Ghost[] ghosts; //��Ʈ�� ������

    public Pacman pacman;

    public Transform pallets;
=======
    public Ghost[] ghosts;
    public Pacman pacman;
    public Transform pellets;
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab

    public int score { get; private set; }
    public int lives { get; private set; }


    private void Start()
    {
        NewGame();
<<<<<<< HEAD
    }
    //�ƹ�Ű�� ������ �� �ٽý���.
    private void Update()
    {
        if (this.lives <= 0 && Input.anyKeyDown)
        {
            NewGame();

        }
=======
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab
    }

    private void NewGame()
    {
        SetScore(0);
        SetLives(3);
        NewRound();
    }

    private void NewRound()
    {
<<<<<<< HEAD
        foreach (Transform pellet in this.pallets)
        {
=======
        foreach (Transform pellet in this.pellets){
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab
            pellet.gameObject.SetActive(true);
        }

        ResetState();
    }

    private void ResetState()
    {
<<<<<<< HEAD
        for (int i = 0; i < this.ghosts.Length; i++)
        {
            this.ghosts[i].gameObject.SetActive(true);
        }
        this.pacman,gameObject.SetActive(true);
=======
        for (int i=0; i<this.ghosts.Length; i++){
            this.ghosts[i].gameObject.SetActive(true);
        }

        this.pacman.gameObject.SetActive(true);
    }
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab

    }
    //�Ѹ��� ��Ƹ����� �� ���ӿ���.
    private void GameOver()
    {
<<<<<<< HEAD
        for (int i = 0; i < this.ghosts.Length; i++)
        {
            this.ghosts[i].gameObject.SetActive(false);
        }
        this.pacman,gameObject.SetActive(false);
=======
        for (int i=0; i<this.ghosts.Length; i++){
            this.ghosts[i].gameObject.SetActive(false);
        }

        this.pacman.gameObject.SetActive(false);
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab
    }

    private void SetScore(int score)
    {
        this.score = score;
    }

    private void SetLives(int lives)
    {
        this.lives = lives;
    }

<<<<<<< HEAD
    //��Ʈ�� �Ծ����� �߰�����.
=======
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab
    public void GhostEaten(Ghost ghost)
    {
        SetScore(this.score + ghost.points);
    }
    //�Ѹ��� ��� ������ ��
    //1.����� 0������ ������ ����� 1���� �پ��� �ٽý���.(3�� �ڿ� �ٽ� ����)
    //2.����� 0�� ���ϸ� ���ӿ���.
    public void PacmanEaten()
    {
        this.pacman.gmaeObject.SetActive(false);

        SetLives(this.lives - 1);
<<<<<<< HEAD
        if (this lives > 0){
            Invoke(nameof(ResetState), 3.0f);
        }else
        {
=======

        if(this.lives > 0){
            Invoke(nameof(ResetState), 3.0f);
        } else {
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab
            GameOver();
        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> d4586f63434c2f0c5ce66827715b71fac83b5eab
