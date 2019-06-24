package com.example.mohammedzaman.irate;

import android.app.DatePickerDialog;
import android.app.Dialog;
import android.app.TimePickerDialog;
import android.os.Bundle;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.view.HapticFeedbackConstants;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.TimePicker;
import android.widget.Toast;

import java.util.Calendar;

public class MainActivity extends AppCompatActivity implements SeekBar.OnSeekBarChangeListener{

    private DatePicker datePicker;
    private TimePicker timePicker1;
    private Calendar calendar;
    private int year, month, day;
    private String format = "";
    int hour;
    int min;


    private TextView dateView;
    private TextView timeView;
    private  TextView ppmValue;
    private  TextView srValue;
    private  TextView qValue;
    private  TextView cValue;

    private SeekBar ppmSeeker;
    private SeekBar srSeeker;
    private SeekBar clSeeker;
    private SeekBar fqSeeker;

    private EditText restName;
    private EditText restType;
    private EditText notes;
    private EditText nameReporter;

    private Button submit;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.content_main);

        // date
        calendar = Calendar.getInstance();
        year = calendar.get(Calendar.YEAR);
        month = calendar.get(Calendar.MONTH);
        day = calendar.get(Calendar.DAY_OF_MONTH);

        // time
        hour = calendar.get(Calendar.HOUR_OF_DAY);
        min = calendar.get(Calendar.MINUTE);

        // seekbars
        ppmSeeker = findViewById(R.id.ppmSlider);
        srSeeker = findViewById(R.id.srSlider);
        clSeeker = findViewById(R.id.cSlider);
        fqSeeker = findViewById(R.id.qSlider);

        // date and time Views
        dateView = (TextView) findViewById(R.id.dovTxt);
        timeView = (TextView) findViewById(R.id.tovTxt);


        // textbox values for seekbar
        ppmValue = findViewById(R.id.ppmValueTxt);
        srValue = findViewById(R.id.serviceValueTxt);
        cValue  = findViewById(R.id.cleanValueTxt);
        qValue = findViewById(R.id.qualValueTxt);


        // Event Handler for Seekbar
        ppmSeeker.setOnSeekBarChangeListener(this);
        srSeeker.setOnSeekBarChangeListener(this);
        clSeeker.setOnSeekBarChangeListener(this);
        fqSeeker.setOnSeekBarChangeListener(this);

        // removing key listener for date and time fields
        dateView.setKeyListener(null);
        timeView.setKeyListener(null);

        // Textboxes
        restName = findViewById(R.id.restaurantTxt);
        restType = findViewById(R.id.restaurantType);
        notes = findViewById(R.id.notesEdit);
        nameReporter = findViewById(R.id.nameEdit);

        // button
        submit = findViewById(R.id.submit);



        // click events handled here
        submit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                v.performHapticFeedback(HapticFeedbackConstants.VIRTUAL_KEY); // haptic feedback
                validate();
            }
        });

        dateView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                showDialog(999);

            }
        });

        timeView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                showDialog(888);

            }
        });


    }



    //================================================================================
    //Validation for fields
    //================================================================================

    public void validate(){
        if(restName.getText().toString().matches("")){
         restName.setError("This field is required");
        }else if(restType.getText().toString().matches("")) {
            restType.setError("This field is required");
        }else if(dateView.getText().toString().matches("")){
            dateView.setError("select Date");
        }else if(timeView.getText().toString().matches("")){
            timeView.setError("select time");
        }else if(ppmSeeker.getProgress() == 0 || clSeeker.getProgress() == 0 || srSeeker.getProgress() == 0 || fqSeeker.getProgress() == 0){
            messageBox("Error!", "Please select all the required Fields");
        }else if(nameReporter.getText().toString().matches("")){
            nameReporter.setError("This field is required");
        }else{
            messageBox("Success" , "All the Fields are filled in");
            reset();
        }
    }



    //================================================================================
    //Dialog Creator
    //999 for Date Dialog
    //888 for Time Dialog
    //================================================================================
    @Override
    protected Dialog onCreateDialog(int id) {
        // TODO Auto-generated method stub
        if (id == 999) {
            return new DatePickerDialog(this,
                    myDateListener, year, month, day);
        }else if(id == 888){
            return new TimePickerDialog(this , myTimePicker,hour ,min,false);

        }
        return null;
    }

    private DatePickerDialog.OnDateSetListener myDateListener = new
            DatePickerDialog.OnDateSetListener() {
                @Override
                public void onDateSet(DatePicker arg0,
                                      int arg1, int arg2, int arg3) {
                    showDate(arg1, arg2+1, arg3);
                }
            };




    //================================================================================
    //Date Picker Implementation
    //================================================================================
    private void showDate(int year, int month, int day) {
        dateView.setText(new StringBuilder().append(day).append("/")
                .append(month).append("/").append(year));
    }

    private TimePickerDialog.OnTimeSetListener myTimePicker  = new TimePickerDialog.OnTimeSetListener() {
    @Override
    public void onTimeSet(TimePicker view, int hourOfDay, int minute) {
     showTime(hourOfDay,minute);
       }
    };

    @SuppressWarnings("deprecation")
    public void setDate(View view) {
        showDialog(999);
        Toast.makeText(getApplicationContext(), "ca",
                Toast.LENGTH_SHORT)
                .show();
    }



    //================================================================================
    //Time Picker implementation
    //================================================================================
    public void setTime(View view) {
        int hour = timePicker1.getCurrentHour();
        int min = timePicker1.getCurrentMinute();
        showTime(hour, min);
    }

    public void showTime(int hour, int min) {
        int minute = min;
        if (hour == 0) {
            hour += 12;
            format = "AM";
        } else if (hour == 12) {
            format = "PM";
        } else if (hour > 12) {
            hour -= 12;
            format = "PM";
        }else if(min == 0){
            minute = Integer.parseInt(Integer.toString(min) + Integer.toString(0));

        }
        else {
            format = "AM";
        }

        timeView.setText(new StringBuilder().append(hour).append(" : ").append(minute)
                .append(" ").append(format));
    }


    //================================================================================
    //Seekbar updates are implemented here, the text boxes can be updated here
    //================================================================================
    @Override
    public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
        if(seekBar.getId() == R.id.ppmSlider) {
            if(progress != 0) {
                ppmValue.setText("£" + progress);
            }else{
                ppmValue.setText("select price per meal !");
            }
        }else if(seekBar.getId() == R.id.srSlider){

            if(progress == 0 ){
                srValue.setText("Please select a service rating !");
            }else if(progress == 1){
                srValue.setText("Very bad");
            }else if(progress == 2){
                srValue.setText("Bad");
            }else if(progress == 3){
                srValue.setText("Okay");
            }else if(progress == 4){
                srValue.setText("Good");
            }else if(progress == 5) {
                srValue.setText("Very Good");

            }
        }else if(seekBar.getId() == R.id.cSlider){
            if(progress == 0 ){
                cValue.setText("Please select a cleanliness rating !");
            }else if(progress == 1){
                cValue.setText("Very bad");
            }else if(progress == 2){
                cValue.setText("Bad");
            }else if(progress == 3){
                cValue.setText("Okay");
            }else if(progress == 4){
                cValue.setText("Good");
            }else if(progress == 5) {
                cValue.setText("Very Good");

            }

        }else if(seekBar.getId() == R.id.qSlider){

            if(progress == 0 ){
                qValue.setText("Please select a food Quality rating !");
            }else if(progress == 1){
                qValue.setText("Very bad");
            }else if(progress == 2){
                qValue.setText("Bad");
            }else if(progress == 3){
                qValue.setText("Okay");
            }else if(progress == 4){
                qValue.setText("Good");
            }else if(progress == 5) {
                qValue.setText("Very Good");

            }

        }

    }


    //================================================================================
    //Reset the Textboxes and Seekbars
    //================================================================================
    public void reset(){
        restName.getText().clear();
        restType.getText().clear();
        timeView.setText("");
        dateView.setText("");
        ppmSeeker.setProgress(0);
        srSeeker.setProgress(0);
        clSeeker.setProgress(0);
        fqSeeker.setProgress(0);
        notes.getText().clear();
        nameReporter.getText().clear();
    }


    //================================================================================
    //General message box method for reuse
    //================================================================================
    public void messageBox(String title , String message){
        new AlertDialog.Builder(this)
                .setTitle(title)
                .setMessage(message)
                .show();
    }

    @Override
    public void onStartTrackingTouch(SeekBar seekBar) {

    }

    @Override
    public void onStopTrackingTouch(SeekBar seekBar) {

    }
}
