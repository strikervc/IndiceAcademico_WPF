   M S B A M L   `   `   `  ����J  FIndiceAcademico, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:IndiceAcademico.mainwindowsIndiceAcademico.mainwindows  5      .    (IndiceAcademico.mainwindows.IndiceWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:IndiceAcademico.mainwindows     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��124* �6   �� 5      $
��295* �6   .+�5   
   �� $��Indice Academico��6   $��	37,24,0,0q�6+   $	��Top=�6>   $��22(�6l   $��MS Reference Sans Serif)�6z   
���   �$
��Left=�6�   $	��217��6�   ��6V   Z� 6�   �� 5   
   ���	#FFFF2D2D$��4��6%   $��
40,65,40,0q�60   $	��Top=�6D    J� RenderTransformOrigin$ 0.5,0.5&�6\   �� 5   
   -   5         ��Name$ ListEstudiantes��5      $
��Left=�6,   $��
477,22,0,0q�6G   $	��Top=�6[   $	��120��6s   6   �� 5   
   -   5         ��Name$ Calcular��5      $��Calcular��6#   $
��Left=�66   $��
383,24,0,0q�6Q   $	��Top=�6e   $��76��6}   6�   �� 5   
   -   5         ��Name$ ListaIndice��5      $
��Left=�6(   $	��200��6C   $��	41,95,0,0q�6P   $	��Top=�6c   $	��556��6{   $��2��6�   $��13(�6�   ���	#FFE2E2E2���	#FF710404���	#FFCB9A9A �� View 5      �� 5      .P�5      �� $��
Asignatura��6%    �� DisplayMemberBinding 69   �� *
Asignatura+�� 5      $��Creditos��6%    67   �� *
Creditos+�� 5      $
��Nota��6%    63   �� *Nota+�� 5      $��Valor de la Nota��6%    6?   �� *	ValorNota+�� 5      $��Puntos de Honor��6%    6>   �� *PuntosHonor+5      5      �� 5   
   $��Total de Puntos de Honor:��6   $
��Left=�64   $��
41,176,0,0q�6O   $��1��6c   $	��Top=�6p   $��15(�6�   $��Italic$�6�   �� 5   
   $��Total de Créditos:��6   $
��Left=�6-   $��
41,211,0,0q�6H   $��1��6\   $	��Top=�6i   $��15(�6�   $��Italic$�6�   �� 5   
   $��Indice General:��6   $
��Left=�6*   $��
41,246,0,0q�6E   $��1��6Y   $	��Top=�6f   $��15(�6~   $��Italic$�6�   �� 5    
   -   5         ��Name$ TotalPuntosHonor��5       $��Right=�6*   $��
0,176,40,0q�6F   $��1��6Z   $	��Top=�6g   $��15(�6   $��DemiBold"�6�   �� 5!   
   -   5        $ TotalCreditos��5!      $��Right=�6'   $��
0,211,40,0q�6C   $��1��6W   $	��Top=�6d   $��15(�6|   $��DemiBold"�6�   �� 5"   
   -   5        $ IndiceGeneral��5"      $��Right=�6'   $��
0,246,40,0q�6C   $��1��6W   $	��Top=�6d   $��15(�6|   $��DemiBold"�6�   �� 5#   
   -   5        $ 
btnRanking��5#      $��Ranking��6&   $
��Left=�68   $	��Top=�6S   $��75��6k   $��
287,24,0,0q�6v   $��20��6�   6�   5$      5&      