using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ToDoItemApp.Models
{
    public class TodoItemsCollection : ObservableCollection<TodoItem>   // IList<TodoItem>, List<TodoItem>
    {
        public void CopyFrom(IEnumerable<TodoItem> todoItems)
        {
            this.Items.Clear();     // ObservableCollection<T> 자체가 Items 속성을 가지고있음. 모든 속성 삭제

            foreach (TodoItem item in todoItems)
            {
                this.Items.Add(item);       // 하나씩 다시 추가
            }

            // 데이터 바뀜(전부 초기화)
            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}
