   M S B A M L   `   `   `  ????D  @ctTextBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:ctTextBox;assembly=ctTextBox	ctTextBox  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   bg-cor-titulo  bg-cor-rodape  bg-cor-menu  bg-primary-light  
bg-primary  bg-secondary  bg-success-light  
bg-success  bg-danger-light 	 	bg-danger 
 
bg-warning  bg-info  bg-light  bg-white  bg-gray-light  bg-gray  bg-dark  bg-black  
cor-titulo  ?? Color  
cor-rodape  cor-menu  primary-light  primary  	secondary  success-light  success  danger-light 
 danger  warning  info 	 light 	 white   
gray-light ! gray " dark 	# black $ 
MainWindow ?? 
TargetType ?? Property ?? Value 
% Window & 
GridTitulo ' 
GridMargin ( TextBox ?? 
TargetType ?? CornerRadius ?? Padding'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 ?? 
TargetName ?? TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame ?? KeyTime ?? Value ??Name   ctTextBox.ctAutoComplete ) TextboxStyle2p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35-  'System.Windows.Controls.AutoCompleteBox?? 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      8	ctTextBox*clr-namespace:ctTextBox;assembly=ctTextBox  5      %?  &	        &	      &	 >     &	 ]     &	 ~     &	 ?     &	 ?     &	 ?     &	     &		 #    &	
 D    &	 e    &	 ?    &	 ?    &	 ?    &	 ?    &	 
    &	 +    &	 L    &	 f    &	 ?    &	 ?    &	 ?    &	 ?    &	 ?    &	     &	     &	 6    &	 P    &	 j    &	 ?    &	 ?    &	  ?    &	! ?    &	" ?    &	#     &	$      7  &	% +    7  7  &	& ?    7  &	' ?    &	( ?    &	) ?    7 ( ??5      #006388??6+   ??5      #f5d323??6+   ??5	      #6b6b87??6)   ??5      	#FF2a2c3b??60   ??5      	#FF2a2c3b??6*   ??5      	#FF0b0686??6,   ??5      	#FF0ee27a??60   ??5      	#FF00aa57??6*   ??5      	#FFff4d5d??6/   ??5      	#FFc82333??6)   ??5      	#FFfFFF00??6*   ??5      	#FFff8b00??6'   ??5      	#FFeff3f6??6(   ??5      	#FFFFFFFF??6(   ??5      	#FFbbbbbb??6-   ??5      	#FFcccccc??6'   ??5      	#FF343a40??6'   ??5      	#FF111111??6(   ?? 5      #  ?   6)   ?? 5      #  ?  6)   ?? 5      #  ?  6'   ?? 5      #  ?  6,   ?? 5       #  ?  6&   ?? 5!      #  ?  6(   ?? 5"      #  ?  6,   ?? 5#      #  ?  6&   ?? 5$      #  ?  6+   ?? 5%      #  ? 	 6%   ?? 5&      #  ? 
 6&   ?? 5'      #  ?  6#   ?? 5(      #  ?  6$   ?? 5)      #  ?  6$   ?? 5*      #  ?  6)   ?? 5+      #  ?  6#   ?? 5,      #  ?  6#   ?? 5-      #  ?  6$   ?? 50      " ?6   .?51   
   ??  ?@?WindowStyle$
 None=?6(   ?? 52   
    ?@?WindowState$ 	Maximized=?6(   ?? 53   
    ? ??8   6(   ?? 54   
    ? ??$ 1q?6,   ?? 55   
    ?@?Title$ Treinamento - Sizex??6"   56      ?? 58      " ?6   .?59   
   ??  ? ??8   6'   ?? 5:   
    ? ??8  6(   ?? 5;   
    ?@?WindowStyle$
 None=?6(   ?? 5<   
    ?@?
ResizeMode$ 	CanResize=?6'   5=      ?? 5@      " ?6   .?5A   
   ??  ? ??8   6'   ?? 5B   
    ? ??$ 40??6#   ?? 5C   
    ? ??$	 Top=?6.   ?? 5D   
    ? ??$
 auto??6"   5E      ?? 5F      " ?6   .?5G   
   ??  ? ??$ 0,0,0,5q?6#   5H      ?? 5N      " ??6   .?5O   
   ??  ? ??$
 auto??6"   ?? 5P   
    ?@??CharacterCasing$ Upper=?6,   ?? 5Q   
    ? ??$	 2,2q?6$   ?? 5R   
    ?@??SelectionBrush# ?  6+   ?? 5S   
    ? ??$	 Top=?6.   ?? 5T   
    ? ??$ 14(?6%   ?? 5U   
    ? ??$
 Bold"?6'   ?? 5V   
    ? ??$ Calibri)?6'   ?? 5W   
    ?@??
CaretBrush# ? # 6'   ?? 5X   
    ? ?? 5Y      ?? 5Z      " ??6"   .R?5[      ?? $??Border??6   $ 2??6+   $ 0q?6<   $??1q?6H   $
??auto??6\   ??5\      ?? 5]      #  ?  6.   ??5_      ?? 5`      $  	#FF2E235F??6.    5b        5c      CommonStats??. 5d   "     
Normal??6.     5e   "   Disable??.	 5f   &   ?? .??5g   *   ?? $
 Border??6G   $0 *(Panel.Background).(SolidColorBrush.Color)?6f   .g?5h   .     $ 0??6B   $ #eeeeee??6N   5i   +   ?? 5j   *   $
 Border??6G   $2 ,(Border.BorderBrush).(SolidColorBrush.Color)?6f   .g?5k   .     $ 0??6B   $ #aaaaaa??6N   5l   +   5m   '   5n   #     5o   "   ReadOnly??6.     5p   "   	MouseOver??6.   5q      ._?5s      ?? $ PART_ContentHost??62   $??0q?6'   62   5t      5u      5w      5x      ?? 5y      "  6   .?5z   
   ??  ?@ TextBoxStyle8   6)   ?? 5|   
    ? ??$ 1q?6,   ?? 5}   
    ? ??$
 auto??6"   ?? 5~   
    ? ??$	 2,2q?6$   ?? 5   
    ? ??$	 Top=?6.   ?? 5?   
    ? ??$ 14(?6%   ?? 5?   
    ?@ IsTextCompletionEnabled . 64   5?      5?      