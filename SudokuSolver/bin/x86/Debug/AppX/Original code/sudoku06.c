#include <stdio.h>

#include <stdlib.h>
#include<conio.c>
#include<conio.h>
// more change 
int ar[9][9]={0,9,0,0,0,0,2,0,1,
              6,2,0,0,0,0,8,0,0,
              0,0,0,1,0,0,4,0,0,
              0,0,0,0,0,4,0,8,3,
              3,0,0,8,0,6,0,0,7,
              4,1,0,3,0,0,0,0,0,
              0,0,6,0,0,5,0,0,0,
              0,0,3,0,0,0,0,1,2,
              9,0,2,0,0,0,0,6,0};

int valid(int,int,int);
void display();
void generate(int );

int main()
{
 int ch;
  
 display();
 printf("If you want to see each step of result press 1.\nPress 0 for only the final result:  ");
 scanf("%d",&ch);
 generate(ch);
 display();
 system("PAUSE");	
 
 return 0;
}

void display()
{int i,j;
 printf("\n------------------\n");
 for(i=0;i<9;i++)
  {
    for(j=0;j<9;j++)
      {
       printf("%d",ar[i][j]);
        if ((j==2)||(j==5))
           printf(" || ");
       }
           
   printf("\n");
  if((i==2)||(i==5))
     printf("-----------------\n"); 
  } 
   printf("------------------\n");

}

int valid( int r,int c,int no)
{int i,j,rowst=0,colmn_st=0;
 
 //test if any entry is in that pos. already....
 if(ar[r][c]>0 && ar[r][c]<10)
   return -1;
 
 else{
       // if no. is already in the horizontal or vertical pos..
       for(i=0;i<9;i++)
          {if((ar[i][c]==no)||(ar[r][i]==no))
          return 0;
          }
          
       //check in small box   rowst ,colmn_st is the starting row no. ,col no. for grid..
        if(r>2)
        {if(r>5)
           rowst=6;
         else
          rowst=3;
        }
            
     if(c>2)
        {if(c>5)
           colmn_st=6;
         else
          colmn_st=3;
        }
            
  
       for(i=rowst;i<rowst+3;i++)
         for(j=colmn_st;j<colmn_st+3;j++)
            {if(ar[i][j]==no)
               return 0;
             }
      return 1;
      }
      
}

void generate(int ch)
{int flag1=0,flag2=1,rowst,colmn_st,l2_k,i1,l2_j;
 int l2_i,l3_j,l3_i,l3_k1,l3_j1,c,co=0,j,k,i,count=0,no,n,po[9],countp=0;
 
 do{
    do{flag1=0; 
       for(j=0;j<9;j++)
        for(k=0;k<9;k++)
           {count=0;
            for(i=1;i<10;i++)
               {
                c=valid(j,k,i);
                if(c==-1)
                   break;
                   
                 if(c==1)
                 {count++;
                  no=i;
                  }
                
                if(count==2)//more than one no. is valid 
                 break;
                 
                     
               }
                 
          //logic 1.    for every cell check if only one no. is valid.. 
          if(count==1)
          {flag1=1;
           ar[j][k]=no;
           if(ch==1)
            {  
             display();
             getch();
            }
                                    
         
          }
          
           /* logic 2  ..to test the choices. if one of the choice isnt repeated it is entered into the cell..
           
            suppose positon(2,3) has 2,3,4 as valid chioce. if the no. 2 is not a choice in the (other cell of)2nd row
           no. 2 has to be in position(2,3)...  similarly check for other choices if 2 is repeated. also check in 3rd column,and the grid similarly.
         */
        
          if(count==2)
         {          for(i=1;i<10;i++)
                        {
                                       c=valid(j,k,i);
                                       if(c==1)
                                         { flag2=1;// checking in the column
                                           for(l2_k=0;l2_k<9;l2_k++)
                                                 {if(l2_k==k)
                                                     continue;
                                                    for(l2_i=1;l2_i<10;l2_i++)
                                                       { 
                                                         co=valid(j,l2_k,l2_i);
                                                         if(co==1)
                                                           {if(l2_i==i)
                                                               {flag2=0;
                                                                  break;
                                                                }  
                                                           }
                             
                                                       }
                                                   if(flag2==0)
                                                       break;
                                                 }
                                   
                                            if(flag2==0)// checking in the row
                                               { flag2=1;
                                                 for(l2_j=0;l2_j<9;l2_j++)
                                                    { if(l2_j==j)
                                                        continue;
                                                      for(l2_i=1;l2_i<10;l2_i++)
                                                         { 
                                                          co=valid(l2_j,k,l2_i);
                                                          if(co==1)
                                                              {if(l2_i==i)
                                                                 { flag2=0;
                                                                    break;
                                                                  }  
                                                               }
                             
                                                         }
                                                   if(flag2==0)
                                                      break;
                                                  }
                                               }
                                           
                                                   //  checking in the grid
                                             if(flag2==0)
                                              {
                                                 flag2=1;
                                                 rowst=0;
                                                 colmn_st=0;   
                                                 
                                                  if(j>2)
                                                    {if(j>5)
                                                        rowst=6;
                                                      else
                                                         rowst=3;
                                                     }
                                                     
                                                 if(k>2)
                                                    {if(k>5)
                                                       colmn_st=6;
                                                     else
                                                        colmn_st=3;
                                                   }
            
  
                                                 
                                                 for(l2_j=rowst;l2_j<rowst+3;l2_j++)
                                                   {  for(l2_k=colmn_st;l2_k<colmn_st+3;l2_k++)
                                                         {if((l2_j==j)&&(l2_k==k))
                                                           continue;
                                                            
                                                          for(l2_i=1;l2_i<10;l2_i++)
                                                           {
                                                            co=valid(l2_j,l2_k,l2_i);
                                                            if(co==1)
                                                             {if(l2_i==i)
                                                               {flag2=0;
                                                                  break;
                                                                }  
                                                             }
                             
                                                           }
                                                           if(flag2==0)
                                                             break;
                                                        } 
                                                       if(flag2==0)
                                                        break;                                                                                                                                                                                                            
                                               
                                                                                          
                                                  } 
                                                                                             
                                           }  
                                           
                                             
                                                 
                                                         
                                               
                   
                    if(flag2==1)
                     { ar[j][k]=i;   
                       flag1=1;
                       if(ch==1)
                       {
                        display();
                        getch();
                       }      
                        break;
                      }  
          
                
                   }
                 }     
             }
              
          
        }
          
          

   }while(flag1==1);
    
 
            
              //logic 3..
               /* this is slightly more complicated
                  i have to show  some diagrams 
                  see the diagram 
                */
                
                for(j=0;j<9;j++)
                  {
                   for(k=0;k<9;k++)
                     {countp=0;
                      // c=0;
                       for(i=1;i<10;i++)
                         {
                           c=valid(j,k,i); 
                           if(c==-1)
                            break;
                           if(c==1)
                             {po[countp]=i;
                              countp++;
                              }
                  
                          }
                       if(c==-1)
                         continue;             
              
                      else                
                           { //checking in the row
                            for(l3_j=0;l3_j<9;l3_j++)
                               {                rowst=0;
                                                colmn_st=0;   
                                              
                                                  if(l3_j>2)
                                                    {if(l3_j>5)
                                                        rowst=6;
                                                      else
                                                         rowst=3;
                                                     }
                                                     
                                                 if(k>2)
                                                    {if(k>5)
                                                       colmn_st=6;
                                                     else
                                                        colmn_st=3;
                                                   }
            
                                    if(l3_j==j)
                                     continue;
                                    
                                    for(l3_i=1;l3_i<10;l3_i++)
                                      { 
                                       co=valid(l3_j,k,l3_i);
                                       if(co==1)
                                          for(i1=0;i1<countp;i1++)
                                            if(po[i1]==l3_i)
                                             {
                                                 
  
                                                flag2=1;
                                                ///*
                                                 for(l3_j1=rowst;l3_j1<rowst+3;l3_j1++)
                                                     for(l3_k1=colmn_st;l3_k1<colmn_st+3;l3_k1++)
                                                         {if(l3_k1==k)
                                                           continue;
                                                            
                                                            for(n=1;n<10;n++)
                                                             {
                                                              co=valid(l3_j1,l3_k1,n);
                                                              if(co==1)
                                                               { if(n==l3_i)                                                           
                                                                  {flag2=0;
                                                                   break;
                                                                   }
                                                                   
                                                               }
                             
                                                             }
                                                            
                                                         if(flag2==0)
                                                           break;
                                                        }    
                                                 
                                                 if(flag2==1)
                                                   po[i1]=0;    
                                            }         
                     
    
                                        } 
                            
                                 }  
                      
          
                          flag2=0;
                         for(i1=0;i1<countp;i1++)
                           {if(po[i1]!=0)
                             {flag2++;
                              n=po[i1];
                             }
                      
                           } 
                        
                        if(flag2==1)
                         { ar[j][k]=n;   
                           if(ch==1)
                             {display();
                              getch();
                             }
                               
                            flag2=7;//exit from logic 3
                                                
                                      
                         }  
                   
                  
                    } 
                    if(flag2==7)
                     break;                
               
                 }
                 if(flag2==7)
                  break;                                                                                                    
            }                                           
         
                        
 
   }while(flag2==7);   
        
     
}                                                                                                                  
