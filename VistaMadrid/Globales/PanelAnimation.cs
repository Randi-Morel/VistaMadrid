using System;
using System.Drawing;
using System.Windows.Forms;

public static class PanelAnimationHelper
{
    private static Timer animationTimer;
    private static Panel currentPanel;
    private static int targetHeight;
    private static int startHeight;
    private static int animationStep;
    private static bool isExpanding;
    private static Action onAnimationComplete;

    /// <summary>
    /// Anima un panel para plegarlo o desplegarlo
    /// </summary>
    /// <param name="panel">Panel a animar</param>
    /// <param name="expand">True para expandir, False para contraer</param>
    /// <param name="targetHeight">Altura objetivo (solo necesario al expandir)</param>
    /// <param name="animationSpeed">Velocidad de animación en milisegundos (por defecto 15ms)</param>
    /// <param name="onComplete">Acción a ejecutar cuando termine la animación</param>
    public static void AnimatePanel(Panel panel,bool expand, int targetHeight = 0, 
                                   int animationSpeed = 10, Action onComplete = null)
    {
        // Detener animación anterior si existe
        StopAnimation();

        currentPanel = panel;
        onAnimationComplete = onComplete;
        isExpanding = expand;
        startHeight = panel.Height;

        if (expand)
        {
            // Si no se especifica altura objetivo, usar la altura almacenada o 200px por defecto
            if (targetHeight == 0)
            {
                targetHeight = (int)(panel.Tag ?? 200);
            }
            PanelAnimationHelper.targetHeight = targetHeight;
            
            // Guardar la altura objetivo en el Tag del panel para futuras contracciones
            panel.Tag = targetHeight;
        }
        else
        {
            // Contraer a altura 0
            PanelAnimationHelper.targetHeight = 0;
        }

        // Calcular el paso de animación (diferencia / número de frames)
        int heightDifference = Math.Abs(PanelAnimationHelper.targetHeight - startHeight);
        animationStep = Math.Max(1, heightDifference / 20); // 20 frames aproximadamente

        // Configurar y iniciar el timer
        animationTimer = new Timer();
        animationTimer.Interval = animationSpeed;
        animationTimer.Tick += AnimationTimer_Tick;
        animationTimer.Start();
    }

    /// <summary>
    /// Alterna entre expandir y contraer el panel
    /// </summary>
    /// <param name="panel">Panel a animar</param>
    /// <param name="expandedHeight">Altura cuando está expandido</param>
    /// <param name="animationSpeed">Velocidad de animación</param>
    /// <param name="onComplete">Acción a ejecutar cuando termine</param>
    public static void TogglePanel(Panel panel, int expandedHeight, 
                                  int animationSpeed = 10, Action onComplete = null)
    {
        bool shouldExpand = panel.Height <= 10; // Considerar contraído si altura <= 10
        AnimatePanel(panel, shouldExpand, expandedHeight, animationSpeed, onComplete);
    }

    private static void AnimationTimer_Tick(object sender, EventArgs e)
    {
        if (currentPanel == null) return;

        int currentHeight = currentPanel.Height;
        
        if (isExpanding)
        {
            // Expandiendo hacia abajo
            if (currentHeight < targetHeight)
            {
                int newHeight = Math.Min(currentHeight + animationStep, targetHeight);
                currentPanel.Height = newHeight;
            }
            else
            {
                currentPanel.Height = targetHeight;
                StopAnimation();
            }
        }
        else
        {
            // Contrayendo hacia arriba
            if (currentHeight > targetHeight)
            {
                int newHeight = Math.Max(currentHeight - animationStep, targetHeight);
                currentPanel.Height = newHeight;
            }
            else
            {
                currentPanel.Height = targetHeight;
                StopAnimation();
            }
        }
    }

    private static void StopAnimation()
    {
        if (animationTimer != null)
        {
            animationTimer.Stop();
            animationTimer.Dispose();
            animationTimer = null;
        }

        // Ejecutar callback si existe
        onAnimationComplete?.Invoke();
        onAnimationComplete = null;
        currentPanel = null;
    }

    /// <summary>
    /// Detiene cualquier animación en curso
    /// </summary>
    public static void StopCurrentAnimation()
    {
        StopAnimation();
    }
}