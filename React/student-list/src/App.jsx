import StudentList from './studentList.jsx';

function App() {
  const students = [
    { id: 1, name: 'Gosho', age: 7, grade: 1 },
    { id: 2, name: 'Petar', age: 8, grade: 2 },
    { id: 3, name: 'Stanley', age: 7, grade: 1 },
    { id: 4, name: 'Michael', age: 7, grade: 1 },
    { id: 5, name: 'Glados', age: "NaN", grade: '14' },
  ];

  return (
    <div>
      <StudentList students={students} />
    </div>
  );
}

export default App;
