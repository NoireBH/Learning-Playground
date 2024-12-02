import propTypes from 'prop-types';

function StudentList(props){

    let studentsList = props.students;
    const studentsByGrade = studentsList.reduce((acc, student) => {
        if (!acc[student.grade]) {
          acc[student.grade] = [];
        }
        acc[student.grade].push(student);
        return acc;
      }, {});
    
      // Map the grouped students to JSX
      const gradeSections = Object.entries(studentsByGrade).map(([grade, studentsInGrade]) => (
        <div key={grade}>
          <h1>Grade: {grade}</h1>
          <ul>
            {studentsInGrade.map(student => (
              <li key={student.name}>{student.name} - Age: {student.age}</li>
            ))}
          </ul>
        </div>
      ));
    
      return <div>{gradeSections}</div>;
    }

    StudentList.propTypes = {
    students: propTypes.arrayOf(
        propTypes.shape({
        name: propTypes.string.isRequired,
        age: propTypes.number,
      })
    ).isRequired,
  };

// Login.defaultProps = {
//     isLoggedIn: false,
//     userName: "Guest"
// }


export default StudentList